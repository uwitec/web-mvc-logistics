/*************************************************************************
 * 文件名称 ：LoginerBase.cs                          
 * 描述说明 ：定义登陆者
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System.Collections.Generic;
using Zephyr.Utils;
namespace Zephyr.Core
{
    public class LoginerBase
    {
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string AuthToken { get; set; }
    }
}
