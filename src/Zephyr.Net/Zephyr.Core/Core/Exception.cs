/*************************************************************************
 * 文件名称 ：ZephyrException.cs                          
 * 描述说明 ：框架错误定义
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;

namespace Zephyr.Core
{
	public class ZephyrException : Exception
	{
		public ZephyrException(string message): base(message){}
        public ZephyrException(string message, Exception innerException) : base(message, innerException) { }
	}
}
