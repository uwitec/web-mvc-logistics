/*************************************************************************
 * 文件名称 ：ParamDeleteData.cs                          
 * 描述说明 ：删除参数数据
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.Collections.Generic;

namespace Zephyr.Core
{
    public class ParamDeleteData
    {
        public string From { get; set; }
        public List<Condition> Where { get; set; }
   
        public ParamDeleteData()
        {
            From = "";
            Where = new List<Condition>();
        }
    }
}
