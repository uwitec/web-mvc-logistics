/*************************************************************************
 * 文件名称 ：ParamUpdate.cs                          
 * 描述说明 ：更新参数构建
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Dynamic;
using Newtonsoft.Json.Linq;

namespace Zephyr.Core
{
    public class ParamUpdate
    {
        protected ParamUpdateData data;

        public dynamic this[string index]
        {
            get { return data.Columns[index]; }
            set { data.Columns[index] = value; }
        }

        public ParamUpdate Update(string tableName)
        {
            data.Update = tableName;
            return this;
        }

        public ParamUpdate Column(string columnName, object value)
        {
            if (value != null && value.GetType() == typeof(JValue))
            {
                value = ((JValue)value).Value;
            }
            data.Columns[columnName] = value;
            return this;
        }

        public ParamUpdate Where(Condition c)
        {
            data.Where.Add(c);
            return this;
        }

        public ParamUpdate Where(Action<ConditionBuilder> builder)
        {
            var cb = new ConditionBuilder();
            builder(cb);
            data.Where.Add(cb.c);
            return this;
        }

        public ParamUpdate Where(string column, object value)
        {
            var cb = new ConditionBuilder().And(column, value).Symbol("equal");
            data.Where.Add(cb.c);
            return this;
        }

        public ParamUpdate ClearWhere()
        {
            data.Where.Clear();
            return this;
        }

        public ParamUpdate()
        {
            data = new ParamUpdateData();
        }

        public static ParamUpdate Instance()
        {
            return new ParamUpdate();
        }

        public dynamic GetDynamicValue()
        {
            var expando = (IDictionary<string, object>)new ExpandoObject();
            foreach (var c in this.data.Columns)
                expando.Add(c.Key, c.Value);

            return (ExpandoObject)expando;
        }

        public ParamUpdateData GetData()
        {
            return data;
        }

    }
}
