/*************************************************************************
 * 文件名称 ：ParamWhere.cs                          
 * 描述说明 ：参数条件定义
 * 
 * 创建信息 : create by liuhuisheng.xm@gmail.com on 2013-11-8

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using Zephyr.Utils;
using Zephyr.Data;

namespace Zephyr.Core
{
    public class Parameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DataTypes ParameterType { get; set; }
        public ParameterDirection Direction { get; set; }
        public int Size { get; set; }

        public Parameter() {
            ParameterType = DataTypes.Object;
            Direction = ParameterDirection.Input;
            Size = 0;
        }
     }
}
