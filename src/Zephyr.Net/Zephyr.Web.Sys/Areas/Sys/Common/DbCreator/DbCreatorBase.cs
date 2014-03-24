using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using Zephyr.Core;
using Zephyr.Data;

namespace Zephyr.Web.Sys
{
    public abstract class DbCreatorBase
    {
        public string name { get; set; }
        public string server { get; set; }
        public string uid { get; set; }
        public string pwd { get; set; }
        public string database { get; set; }
        public abstract string providerName { get; }

        #region 判断是否需要初始化数据库
        public static readonly bool IsNeedToInitDb;
        static DbCreatorBase()
        {
            IsNeedToInitDb = string.IsNullOrEmpty(GetDefaultConnectionName());
        }

        #region 静态方法，获取默认的数据库连接
        public static string GetDefaultConnectionName()
        {
            var tableFeature = new string[] { "sys_button", "sys_code", "sys_codeType", "sys_log", "sys_loginHistory", "sys_roleMenuColumnMap", "sys_user", "sys_menu" };
            IDbContext db = null;
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");
            foreach (ConnectionStringSettings item in config.ConnectionStrings.ConnectionStrings)
            {
                var provider = Db.Provider(item.ProviderName);
                if (provider == null)
                    continue;

                //特征检测
                db = new DbContext().ConnectionString(item.ConnectionString, provider);
                var sql = string.Empty;
                switch (item.ProviderName)
                {
                    case "SqlServer":
                        sql = string.Format("select name from dbo.sysobjects where name in ('{0}')", string.Join("','", tableFeature));
                        break;
                    case "MySql":
                        sql = string.Format("select TABLE_NAME as TableName from information_schema.TABLES where TABLE_SCHEMA= database() and TABLE_NAME in ('{0}')", string.Join("','", tableFeature));
                        break;
                }

                if (string.IsNullOrEmpty(sql))
                    continue;

                var result = db.Sql(sql).QueryMany<dynamic>();
                if (result.Count == tableFeature.Length)
                    return item.Name;
            }

            return string.Empty;
        }
        #endregion

        public static bool IsCanInitDb
        {
            get{return HttpContext.Current.Request.Url.Host == "localhost";}
        }
        #endregion

        #region 静态方法，根据数据库类型获取创建器
        public static DbCreatorBase GetDbCreatorByProvider(string providerName)
        {
            var dict = new Dictionary<string, DbCreatorBase>();
            var assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types.Where(x => x.BaseType == typeof(DbCreatorBase)))
            {
                var instance = Activator.CreateInstance(type) as DbCreatorBase;
                dict[instance.providerName] = instance;
            }

            return dict.ContainsKey(providerName) ? dict[providerName] : null;
        }
        #endregion

        #region 测试数据库连接
        public bool TestConnectionString()
        {
            if (string.IsNullOrEmpty(database))
                return false;
            return Db.TestConnectionString(this.providerName, this.GetConnectionString());
        }

        public bool TestConnectionStringDefaultDatabase()
        {
            return Db.TestConnectionString(this.providerName, this.GetDefaultConnectionString());
        }
        #endregion

        #region 执行数据库创建初始化处理
        public string Execute()
        {
            var provider = Db.Provider(providerName);
            var dbexist = TestConnectionString();
            var db = new DbContext().ConnectionString(GetDefaultConnectionString(), provider);

            //如果数据库不存在，则创建数据库
            if (!dbexist)
            {
                try
                {
                    db.Sql(GetScriptCreateDatabase()).Execute();
                }
                catch (Exception e)
                {
                    db.Dispose();
                    return e.Message;
                }
            }

            try
            {
                //开启事务
                db.UseTransaction(true);
                db.CommandTimeout(60);

                //创建表结构
                var createScript = GetScriptCreateTable();
                if (!string.IsNullOrEmpty(createScript))
                    db.Sql(GetScriptUseDatabase() + createScript).Execute();

                //初始化数据
                var dataScript = GetScriptInsertData();
                if (!string.IsNullOrEmpty(createScript))
                    db.Sql(GetScriptUseDatabase() + dataScript).Execute();

                db.Commit();
            }
            catch (Exception e)
            {
                try
                {
                    db.Rollback();
                    db.UseTransaction(false);
                }
                catch{ }

                //处理失败，删除刚刚创建的数据库
                if (!dbexist)
                    db.Sql(GetScriptDropDatabase()).Execute();
                
                return e.Message;
            }
            finally
            {
                db.Dispose();
            }

            return string.Empty;
        }
        #endregion

        #region 更新web.config
        public void UpdateWebConfig()
        {
            var connName = name ?? "default";
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");
            config.ConnectionStrings.ConnectionStrings.Remove(name);
            config.ConnectionStrings.ConnectionStrings.Add( new ConnectionStringSettings() { Name = name, ProviderName = providerName, ConnectionString = GetConnectionString()});
            config.Save();
        }

        #endregion

        #region 获取默认数据库【master】的连接字符串
        public abstract string GetDefaultConnectionString();
        #endregion

        #region 获取当前数据库连接字符串
        public abstract string GetConnectionString();
        #endregion

        #region 获取数据库创建脚本
        public abstract string GetScriptCreateDatabase();
        #endregion

        #region 获取数据库删除脚本
        public abstract string GetScriptDropDatabase();
        #endregion

        #region 获取切换database脚本
        public abstract string GetScriptUseDatabase();
        #endregion

        #region 获取数据库表结构脚本
        public abstract string GetScriptCreateTable(); 
        #endregion

        #region 获取数据库存初始数据脚本
        public abstract string GetScriptInsertData(); 
        #endregion  
    }
}