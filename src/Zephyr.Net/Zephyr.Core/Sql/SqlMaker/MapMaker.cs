using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Zephyr.Data;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class MapSqlMaker : SqlMakerBase
    {
        public MapSqlMaker(params object[] arguments)
        {
             Arguments = arguments;
        }
  
        public override string Handler(Condition c)
        {
            var sql = c.Column;
            var form = c.Values[0];

            Func<string, object> GetValue = null;
            Func<string, bool> IsContainsKey = null;

            switch (form.GetType().Name)
            {
                case "JObject":
                    var jObj = (JObject)form;
                    IsContainsKey = name => jObj.Property(name)!=null;
                    GetValue = name => jObj[name] == null ? null : ((JValue)jObj[name]).Value;
                    break;
                case "NameValueCollection":
                    var obj = (NameValueCollection)form;
                    IsContainsKey = name => obj.AllKeys.Contains(name);
                    GetValue = name => obj[name];
                    break;
                case "Dictionary`2":
                    var types = form.GetType().GetGenericArguments();
                    if (types[0].Name == "String")
                    {
                        if (types[1].Name == "String")
                        {
                            var dict = (Dictionary<string, string>)form;
                            IsContainsKey = name => dict.ContainsKey(name);
                            GetValue = name => dict.ContainsKey(name) ? dict[name] : null;
                        }
                        else if (types[1].Name == "Object")
                        {
                            var dict = (Dictionary<string, object>)form;
                            IsContainsKey = name => dict.ContainsKey(name);
                            GetValue = name => dict.ContainsKey(name) ? dict[name] : null;
                        }
                    }
                    break;
            }

            if (GetValue == null)
                throw new Exception(string.Format("MapMaker不支持参数类型{0}！",form.GetType().Name));

            var matches = new Regex(@"\{@?([a-zA-Z_][a-zA-Z0-9_]*)\}", RegexOptions.Multiline).Matches(sql);
            foreach (Match match in matches)
            {
                var strs = match.Groups[0].ToString();
                var name = match.Groups[1].ToString();

                if (!IsContainsKey(name))
                    throw new Exception(string.Format("未找到参数{0}对应的值！",strs));

                var value = GetValue(name);

                if (strs.StartsWith("{@"))  //参数化支持
                {
                    sql = sql.Replace(strs, "@" + name);
                    c.Parameters.Add(new Parameter() { Name = name, Value = value, ParameterType = DataTypes.Object, Direction = ParameterDirection.Input, Size = 0 });
                }
                else
                {
                    sql = sql.Replace(strs,ConvertHelper.ToString(value));
                }
            }

            return sql;
        }
    }
}
