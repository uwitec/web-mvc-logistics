/*************************************************************************
 * 文件名称 ：ServiceBaseLog.cs                          
 * 描述说明 ：定义数据服务基类中的日志处理
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using log4net;
using Newtonsoft.Json;

namespace Zephyr.Core
{
    public partial class ServiceBase<T> where T : ModelBase, new()
    {
        protected static ILog Log = LogManager.GetLogger(String.Format("Service{0}", typeof(T).Name));

        protected static void Logger(string function, Action tryHandle, Action<Exception> catchHandle = null, Action finallyHandle = null)
        {
            LogHelper.Logger( Log, function, ErrorHandle.Throw, tryHandle, catchHandle, finallyHandle);
        }

        protected static void Logger(string function, ErrorHandle errorHandleType, Action tryHandle, Action<Exception> catchHandle = null, Action finallyHandle = null)
        {
            LogHelper.Logger( Log, function, errorHandleType, tryHandle, catchHandle, finallyHandle);
        }

        public void Logger(string position,string target,string type,object message) 
        {
            App.OperationLogger(position, target, type, message);
        }
    }
}
