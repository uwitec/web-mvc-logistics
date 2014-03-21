/*************************************************************************
 * 文件名称 ：Column.cs                          
 * 描述说明 ：定义题头
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

namespace Zephyr.Core
{
    public class Column
    {
        public Column()
        {
            rowspan = 1;
            colspan = 1;
        }
        public string field { get; set; }
        public string title { get; set; }
        public int rowspan { get; set; }
        public int colspan { get; set; }
        public bool hidden { get; set; }
    }
}
