/*************************************************************************
 * 文件名称 ：ConditionBuilder.cs                          
 * 描述说明 ：参数条件构造器
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
using Zephyr.Data;
using Newtonsoft.Json.Linq;

namespace Zephyr.Core
{
    public class ConditionBuilder
    {
        const string AND = "and";
        const string OR = "or";

        public Condition c { get; private set; }

        public ConditionBuilder()
        {
            c = new Condition() { Join = AND, Symbol="equal", Parameters = new List<Parameter>() };
        }
 
        public ConditionBuilder And(string column, params object[] values)
        {
            c.Join = AND;
            c.Column = column;
            c.Values = values;
            return this;
        }

        public ConditionBuilder Or(string column, params object[] values)
        {
            c.Join = OR;
            c.Column = column;
            c.Values = values;
            return this;
        }

        public ConditionBuilder Sql(string sql, params object[] values)
        {
            var supportTypes = new string[] { "JObject", "NameValueCollection", "Dictionary`2" };
            var isMap = values.Length == 1 && supportTypes.Contains(values[0].GetType().Name);
            c.Symbol = isMap ? "sqlmap" : "sql";
            c.Column = sql;
            c.Values = values;
            return this;
        }
 
        public ConditionBuilder Symbol(string symbol)
        {
            c.Symbol = symbol.ToLower();
            return this;
        }

        public ConditionBuilder Ignore(Func<Condition, bool> ignore)
        {
            c.Ignore = ignore;
            return this;
        }
 
        public ConditionBuilder Parameter(string name, object value, DataTypes parameterType = DataTypes.Object, ParameterDirection direction = ParameterDirection.Input, int size = 0)
        {
            c.Parameters.Add(new Parameter() { Name=name,Value=value,ParameterType = parameterType,Direction = direction,Size=size });
            return this;
        }
    }
}
