/*************************************************************************
 * 文件名称 ：Db.cs                          
 * 描述说明 ：定义数据库连接
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using log4net;
using Zephyr.Data;
using Zephyr.Utils;
using System.Data.Common;

namespace Zephyr.Core
{
    public class Db
    {
        public static bool TestConnectionString(string dbType, string connectionString)
        {
            var result = false;
            try
            {
                var fullProviderName = GetFullProviderName(dbType);
                if (fullProviderName != null)
                {
                    DbProviderFactory factory = DbProviderFactories.GetFactory(fullProviderName);
                    using (DbConnection conn = factory.CreateConnection())
                    {
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        if ((conn.State & ConnectionState.Open) > 0)
                        {
                            result = true;
                            conn.Close();
                        }
                    }
                }
            }
            catch { }

            return result;
        }

        public static IDbContext Context(string connectionName)
        {
            var Log = LogManager.GetLogger(connectionName);
            var providerName = string.Empty;
            var connectionString = string.Empty;

            if (App.ConnectionHandler != null)
            {
                App.ConnectionHandler(connectionName, ref providerName, ref connectionString);
            }
            else
            {
                var setting = ConfigurationManager.ConnectionStrings[connectionName];
                if (setting == null)
                    throw new Exception(string.Format("未配置连接{0}！",connectionName));
                providerName = setting.ProviderName;
                connectionString = setting.ConnectionString;
            }

            var db = new DbContext().ConnectionString(connectionString, Provider(providerName));
            db.OnExecuting(x =>
            {
                var sql = x.Command.CommandText;

                if (App.EnableZql)
                {
                    //消除字符串影响
                    var values = new List<string>();
                    var matches = new Regex(@"\'(.*?)\'", RegexOptions.Multiline).Matches(sql);
                    for (var i = 0; i < matches.Count; i++)
                    {
                        var matchString = matches[i].Value;
                        if (sql.IndexOf(matchString) > 0) //防止出现相同的字符，被处理两次
                        {
                            sql = sql.Replace(matchString, string.Format("{{{0}}}", values.Count));
                            values.Add(matchString);
                        }
                    }

                    //处理框架定义sql
                    var sType = db.Data.Provider.ToString().Split('.').LastOrDefault().Replace("Provider", "");
                    var dbType = ConvertHelper.ToEnum<DbType>(sType, DbType.Default);

                    matches = new Regex(@"\{([^0-9].*?)\}", RegexOptions.Multiline).Matches(sql);
                    foreach (Match match in matches)
                    {
                        var args = match.Groups[1].Value.Split(',').ToList();
                        var name = args[0];
                        args.RemoveAt(0);
                        var maker = App.DictZql[dbType, name];
                        if (maker == null)
                            throw new Exception(string.Format("未在数据库{0}中注册{1}！", dbType, name));

                        var str = App.DictZql[dbType, name].Handler(args.ToArray());
                        sql = sql.Replace(match.Value, str);
                    }

                    //恢复字符串
                    sql = string.Format(sql, values.ToArray());
                    x.Command.CommandText = sql;
                }

                if (App.OnDbExecuting != null) 
                    App.OnDbExecuting(x);
                 
                //处理输出到日志中的SQL,把参数化的变量替换成字符串
                for (int i = x.Command.Parameters.Count - 1;i>=0;i--)
                {
                    var item = x.Command.Parameters[i] as IDataParameter;
                    sql = sql.Replace(item.ParameterName, String.Format("'{0}'", item.Value));
                }
 
                //写日志
                Log.Debug(sql);
            });

            db.OnError(e =>
            {
                var ex = e.Exception as SqlException;
                if (ex != null)
                {
                    var error = "";
                    switch (ex.Number)
                    {
                        case -2:
                            error = "超时时间已到。在操作完成之前超时时间已过或服务器未响应";
                            break;
                        case 4060:
                            // Invalid Database
                            error = "数据库不可用,请检查系统设置后重试！";
                            break;
                        case 18456:
                            // Login Failed
                            error = "登陆数据库失败！";
                            break;
                        case 547:
                            // ForeignKey Violation
                            error = "数据已经被引用，更新失败，请先删除引用数据并重试！";
                            break;
                        case 2627:
                            // Unique Index/Constriant Violation
                            error = "主键重复，更新失败！";
                            break;
                        case 2601:
                            // Unique Index/Constriant Violation   
                            break;
                        default:
                            // throw a general DAL Exception   
                            break;
                    }
                    if (!string.IsNullOrEmpty(error))
                        throw new Exception(error);
                }
            });

            return db;
        }

        public static IDbProvider Provider(string providerName)
        {
            var providers = new Dictionary<string, IDbProvider>(){
                {"DB2",new DB2Provider()},
                {"MySql",new MySqlProvider()},
                {"Oracle",new OracleProvider()},
                {"PostgreSql",new PostgreSqlProvider()},
                {"SqlAzure",new SqlAzureProvider()},
                {"Sqlite",new SqliteProvider()},
                {"SqlServerCompact",new SqlServerCompactProvider()},
                {"SqlServer",new SqlServerProvider()}
            };
            return providers.ContainsKey(providerName)? providers[providerName]:null;
        }

        public static string GetFullProviderName(string shortProviderName)
        {
            string fullProviderName = null;
            var provider = Provider(shortProviderName);
            if (provider != null)
                fullProviderName = Utils.ReflectionHelper.ToDynamic(provider).ProviderName;

            return fullProviderName;
        }

        public static string GetDefaultDatabaseName(string shortProviderName)
        {
            var defaultDatabases = new Dictionary<string, string>(){
                {"MySql","information_schema"},
                {"SqlServer","master"}
            };

            return defaultDatabases[shortProviderName];
        }
    }
}
