/*************************************************************************
 * 文件名称 ：ParamUpdateData.cs                          
 * 描述说明 ：更新参数数据
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zephyr.Core
{
    public class ParamUpdateData
    {
        public string Update { get; set; }
        public Dictionary<string,object> Columns { get; set; }
        public List<Condition> Where { get; set; }
  
        public ParamUpdateData()
        {
            Update = string.Empty;
            Columns = new Dictionary<string, object>();
            Where = new List<Condition>();
        }
    }
}
