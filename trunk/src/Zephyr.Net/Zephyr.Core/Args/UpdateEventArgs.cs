/*************************************************************************
 * 文件名称 ：UpdateEventArgs.cs                          
 * 描述说明 ：更新事件参数
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using Zephyr.Data;

namespace Zephyr.Core
{
    public class UpdateEventArgs
    {
        public IDbContext db { get; set; }
        public ParamUpdateData data { get; set; }
        public int executeValue { get; set; }
    }
}
