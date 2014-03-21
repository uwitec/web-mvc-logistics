/*************************************************************************
 * 文件名称 ：APP.cs                          
 * 描述说明 ：框架配置类
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class App
    {
        public delegate void ConnectionHandlerDelegate(string name, ref string providerName, ref string connectoinString);

        //属性设置
        public static string DefaultConnectionName = null;
        public static string FormAuthTokenType = "useragent";
        public static SqlDictionary DictSql = AppDefault.LoadDefaultSqlDictionary();
        public static ZqlDictionary DictZql = AppDefault.LoadDefaultZqlDictionary();
        public static Dictionary<string, Func<Condition, bool>> ConditionIgnorer = AppDefault.LoadDefaultIgnorer();
        public static bool EnableZql = true;
       
        //事件支持
        public static Action<CommandEventArgs> OnDbExecuting = null;

        //方法设置
        public static ConnectionHandlerDelegate ConnectionHandler = null;
        public static Func<Dictionary<string, object>> GetDefaultForCreate = AppDefault.GetDefaultForCreate;
        public static Func<Dictionary<string, object>> GetDefaultForUpdate = AppDefault.GetDefaultForUpdate;
        public static Action<SqlDictionary> CustomSqlRegister = null;
        public static Action<ZqlDictionary> CustomZqlRegister = null;
        public static Action<string, string, string, object> OperationLogger = (position, target, type, message) => { };
        public static Func<string> GetDefaultConnectionName = () => { return null; };

        //框架初始化函数
        public static void Init() 
        {
            LogHelper.Init();
            PinYin.GenaratePinYinFunc();
        }
    }
}
