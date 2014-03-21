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
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public partial class RequestWrapper
    {
        private JObject config = new JObject();
        private Dictionary<string, object> data = new Dictionary<string, object>();
        private Func<string, bool> ignore = name => name.StartsWith("_") || new List<string> { null, "page", "rows", "sort", "order", "format", "FLUENTDATA_ROWNUMBER" }.Contains(name);
        private Func<string, bool> include = name => false;

        public object this[string name]
        {
            get{ return data.ContainsKey(name) ? data[name] : null; }
            set{ data[name] = value; }
        }

        public static RequestWrapper Instance()
        {
            return new RequestWrapper();
        }

        public static RequestWrapper InstanceRequest()
        {
            var form = HttpContext.Current.Request.QueryString;
            return new RequestWrapper().SetValue(form);
        }

        public static List<RequestWrapper> InstanceArray(int length)
        {
            var list = new List<RequestWrapper>();
            for (var i = 0; i < length; i++)
                list.Add(new RequestWrapper());

            return list;
        }

        public RequestWrapper SetXml(string str)
        {
            var xml = new XmlDocument();
            xml.LoadXml(str);
            var json = JsonConvert.SerializeXmlNode(xml);
            json = Regex.Replace(json, "{\"settings\":(.*)}", "$1");
            json = Regex.Replace(json, "(@)([a-zA-Z_][a-zA-Z0-9_]*)", "$2");
            config = JsonConvert.DeserializeObject<JObject>(json);

            return this;
        }

        public RequestWrapper SetJson(string str)
        {
            config = JsonConvert.DeserializeObject<JObject>(str);

            return this;
        }

        public RequestWrapper LoadXmlFile(string url)
        {
            var xmlStr = XElement.Load(HttpContext.Current.Server.MapPath(url)).ToString();
            this.SetXml(xmlStr);

            return this;
        }

        public RequestWrapper LoadJsonFile(string url)
        {
            var jsonStr = FileHelper.ReadTxtFile(HttpContext.Current.Server.MapPath(url));
            this.SetXml(jsonStr);

            return this;
        }

        public RequestWrapper SetValue(string name, object value)
        {
            data[name] = value;

            return this;
        }

        public RequestWrapper SetValue(NameValueCollection form)
        {
            foreach (string key in form.Keys)
                data[key] = form[key];

            return this;
        }

        public RequestWrapper SetValue(JToken form)
        {
            if (form != null)
                foreach (JProperty item in form.Children())
                    if (item != null) data[item.Name] = ((JValue)item.Value).Value;

            return this;
        }

        public string GetValue(string name, string defaults = "")
        {
            return ConvertHelper.ToString(this[name], defaults);
        }
 
        public T GetValue<T>(string name, T defaults = default(T))
        {
            return ConvertHelper.To<T>(this[name], defaults);
        }

        //query:where,update,delete:column,where,insert:column
        public RequestWrapper Ignore(Func<string, bool> ignore)
        {
            Func<string, bool> ignoreDefault = this.ignore;
            this.ignore = name => ignoreDefault(name) || ignore(name);

            return this;
        }

        //priority over ignore
        public RequestWrapper Include(Func<string, bool> include)
        {
            this.include = include;

            return this;
        }
   
        public JToken GetConfig(string nodes)
        {
            foreach (var node in nodes.Split(','))
            {
                var result = config.Root;
                foreach (var name in node.Split('.'))
                {
                    if (result == null) break;
                    result = (result as JObject).GetValue(name, StringComparison.OrdinalIgnoreCase);
                }

                if (result != null)
                    return result;
            }

            return null;
        }

        public T GetConfig<T>(string nodes, T defaults = default(T))
        {
            var obj = GetConfig(nodes);
            if (obj == null) return defaults;

            var value = ((JValue)obj).Value;
            var result = ConvertHelper.To<T>(value, defaults);

            return result;
        }

        public ServiceBase GetService()
        {
            var module = GetConfigString("module");
            return new ServiceBase(module);
        }
    }
}
