/*************************************************************************
 * 文件名称 ：APP.cs                          
 * 描述说明 ：框架默认配置
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class AppDefault
    {
        public static string GetDefaultConnectionName()
        {
            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                var provider = Db.Provider(item.ProviderName);
                if (provider != null)
                    return item.Name;
            }

            return string.Empty;
        }

        public static Dictionary<string, Func<Condition, bool>> LoadDefaultIgnorer()
        {
            var dict = new Dictionary<string, Func<Condition, bool>>();
            dict["empty"] = c => c.IsNullOrEmptyValue();

            return dict;
        }

        public static ZqlDictionary LoadDefaultZqlDictionary()
        {
            var dict = new ZqlDictionary();
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t=>t.GetInterfaces().Contains(typeof(ISymbolRegister))); 
            foreach(Type type in types)
            {
                var register = (ISymbolRegister)Activator.CreateInstance(type);
                var zqlMakers = new Dictionary<string,IZqlMaker>();
                register.RegistZQL(zqlMakers);
                dict[register.dbType] = zqlMakers;
            }

            if (App.CustomZqlRegister !=null)
                App.CustomZqlRegister(dict);

            return dict;
        }

        public static SqlDictionary LoadDefaultSqlDictionary()
        {
            var dict = new SqlDictionary();
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t=>t.GetInterfaces().Contains(typeof(ISymbolRegister))); 
            foreach(Type type in types)
            {
                var register = (ISymbolRegister)Activator.CreateInstance(type);
                var sqlMakers = new Dictionary<string,ISqlMaker>();
                register.RegistSQL(sqlMakers);
                dict[register.dbType] = sqlMakers;
            }

            if (App.CustomSqlRegister !=null)
                App.CustomSqlRegister(dict);

            return dict;
        }

        public static Dictionary<string, object> GetDefaultForCreate()
        {
            var user = FormsAuth.GetLoginer();
            var dict = new Dictionary<string, object>
            {
                {"UpdatePerson", user.UserName},
                {"UpdateDate", DateTime.Now},
                {"CreatePerson", user.UserName},
                {"CreateDate", DateTime.Now}
            };
            return dict;
        }

        public static Dictionary<string, object> GetDefaultForUpdate()
        {
            var user = FormsAuth.GetLoginer();
            var dict = new Dictionary<string, object>
            {
                {"UpdatePerson", user.UserName},
                {"UpdateDate", DateTime.Now}
            };
            return dict;
        }
     }
}
