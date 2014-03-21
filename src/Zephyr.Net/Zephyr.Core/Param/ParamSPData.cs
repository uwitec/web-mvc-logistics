/*************************************************************************
 * 文件名称 ：ParamSPData.cs                          
 * 描述说明 ：SP参数数据
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System.Collections.Generic;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class ParamSPData
    {
        public string Name { get; set; }
        public Dictionary<string,object> Parameter { get; set; }
        public Dictionary<string, DataTypes> ParameterOut { get; set; }

        public ParamSPData()
        {
            Name = string.Empty;
            Parameter = new Dictionary<string, object>();
            ParameterOut = new Dictionary<string, DataTypes>();
        }
    }
}
