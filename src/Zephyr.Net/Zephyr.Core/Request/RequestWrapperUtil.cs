/*************************************************************************
 * 文件名称 ：RequestWrapper.cs                          
 * 描述说明 ：请求包装
 * 
 

 *            modify by liuhuisheng on 2013-11-11 for refactoring
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Xml;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public partial class RequestWrapper
    {
        string GetConfigString(string nodes)
        {
            return GetConfig<string>(nodes, string.Empty).Trim("\r\n ".ToCharArray());
        }

        string GetTableName()
        {
            return GetConfigString("table,from,insert,update");
        }

        void BuildCondition(ConditionBuilder builder, JToken c)
        {
            Func<string, string, string> GetPropertyValue = (name, defaults) => (c.Value<string>(name) ?? defaults).Trim("\r\n ".ToCharArray());
            var column = GetPropertyValue("column",string.Empty);
            if (string.IsNullOrEmpty(column))
                throw new Exception("配置中缺少column节点！");

            var valuestr = GetPropertyValue("values", string.Format("{{{0}}}", column.Split('.').Last())); //set defaults
            var values = valuestr.Split(',');
            
            var symbol = GetPropertyValue("symbol","equal");
            var ignore = GetPropertyValue("ignore",string.Empty);
            var join = GetPropertyValue("join","and");

            var objValues = new object[values.Length];//handle values {value}[string] getdate
            for (var i = 0; i < values.Length; i++)
            {
                var v = values[i];
                if (v.StartsWith("{") && v.EndsWith("}"))
                    objValues[i] = this[v.Substring(1, v.Length - 2)];
                else if (v.StartsWith("[") && v.EndsWith("]"))
                    objValues[i] = v.Substring(1, v.Length - 1);
                else
                    objValues[i] = string.Format("{0}", v);
            }

            if (!string.IsNullOrEmpty(ignore))
            {
                if (App.ConditionIgnorer.ContainsKey(ignore))
                    builder.Ignore(App.ConditionIgnorer[ignore]);
                else
                    throw new Exception(string.Format("使用了未定义的条件忽略选项{0}！",ignore));
            }

            if (join == "or")
                builder.Or(column, objValues).Symbol(symbol);
            else
                builder.And(column, objValues).Symbol(symbol);
        }

        void EachWhere(Action<JToken> Handler)
        {
            JToken c = null;
            var where = GetConfig("where");
            if (where == null) return;

            if (where.GetType() == typeof(JArray))
                c = where;
            else if (where.GetType() == typeof(JObject))
                c = where["c"];

            if (c == null) return;
            if (c.GetType() == typeof(JObject))
            {
                Handler(c);
            }
            else if (c.GetType() == typeof(JArray))
            {
                var conditions = (JArray)c;
                foreach (JToken i in conditions.Children())
                    Handler(i);
            }
        }

        void EachColumn(bool IsUpdate, Action<string> handler)
        {
            IEnumerable<string> cols = null;
            var column = GetConfig("column");
            if (column == null) //set default
            {
                var ignoreKeys = new List<string>();
                if (IsUpdate)
                    EachWhere(c => {
                        var col = c.Value<string>("column");
                        var val = c.Value<string>("values");
                        if (val == null || val.Trim("{} ".ToCharArray()) == col)
                            ignoreKeys.Add(col);
                    });
                foreach (var item in this.data.Where(x => this.include(x.Key) || !(this.ignore(x.Key) || ignoreKeys.Contains(x.Key))))
                    handler(item.Key);
            }
            else
            {
                if (column.GetType() == typeof(JArray))
                    cols = column.Values<string>();
                else if (column.GetType() == typeof(JValue))
                    cols = column.Value<string>().Split(',');

                foreach (var name in cols)
                    handler(name);
            }
        }
    }
}
