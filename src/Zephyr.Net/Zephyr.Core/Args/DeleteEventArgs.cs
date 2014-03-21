/*************************************************************************
 * 文件名称 ：DeleteEventArgs.cs                          
 * 描述说明 ：删除事件参数
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司 
 **************************************************************************/

using Zephyr.Data;

namespace Zephyr.Core
{
    public class DeleteEventArgs
    {
        public IDbContext db { get; set; }
        public ParamDeleteData data { get; set; }
        public int executeValue { get; set; }

        public string GetValue(string name)
        {
            foreach (var c in data.Where)
                if (c.Column == name)
                    return c.GetValue();

            return null;
        }
    }
}
