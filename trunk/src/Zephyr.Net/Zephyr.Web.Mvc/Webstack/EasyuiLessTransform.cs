using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Zephyr.Utils;

namespace Zephyr.Web.Mvc
{
    public class EasyuiLessTransform : IBundleTransform
    {
        private string _theme;
        private string _template = "~/Content/css/less/tmpl-easyui.css";
     
        public EasyuiLessTransform(string theme)
        {
            _theme = theme;
        }

        public void Process(BundleContext context, BundleResponse response)
        {
            var source = string.Format("~/Content/js/easyui/{0}/themes/{1}/easyui.css", AppSettings.EasyuiVersion, _theme);
            var sourcePath = HttpContext.Current.Server.MapPath(source);
            var sourceCss = FileHelper.ReadTxtFile(sourcePath);
         
            //读取easyui.css
            var dict = new Dictionary<string, NameValueCollection>();
            foreach (var item in sourceCss.Replace("\r\n", "").Split('}'))
            {
                if (string.IsNullOrWhiteSpace(item))
                    continue;

                var arr = item.Split('{');
                var names = arr[0].Split(',');
                var valueStrings = arr[1].Split(';');
                var dictVal = new NameValueCollection();
                foreach (var valueString in valueStrings)
                {
                    if (string.IsNullOrWhiteSpace(valueString))
                        continue;

                    var valueItem = valueString.Split(':');
                    var key = valueItem[0].Trim();
                    var value = valueItem[1].Trim();
                    dictVal[key] = value;
                }

                foreach (var str in names)
                {
                    var name = str.Trim();
                    if (!dict.ContainsKey(name))
                        dict[name] = new NameValueCollection();

                    foreach (var key in dictVal.AllKeys)
                    {
                        if (dict[name].AllKeys.Contains(key))
                            dict[name][key] += "," + dictVal[key];
                        else
                            dict[name][key] = dictVal[key];
                    }
                }
            }

            //生成变量
            var dictVariable = new Dictionary<string, string>();
            var templatePath = HttpContext.Current.Server.MapPath(_template);
            var templateCss = FileHelper.ReadTxtFile(templatePath);
            var stringBuilder = new StringBuilder();
            templateCss = Regex.Replace(templateCss, @"\/\*.*\*\/", string.Empty, RegexOptions.Multiline);
            dictVariable.Add("theme", _theme);//添加主题变量

            //name:selector[attrube][index](arg1,arg2);
            foreach (var item in templateCss.Replace("\r\n", "").Split(';'))
            {
                if (string.IsNullOrWhiteSpace(item))
                    continue;

                //取得属性
                var arr = item.Split(':');
                var arr2 = arr[1].Split('(');  //0selector[attrube][index] 1arg1,arg2);
                var arr3 = arr2[0].Split('['); //0selector 1attrube] 2index]

                var name = arr[0];
                var value = "null";
                var selector = arr3[0].Trim();
                var attribute = string.Empty;

                //处理函数
                if (selector.StartsWith("@")) // @exist(a,b);
                {
                    var fn = arr2[0].Trim().Trim('@');
                    if (fn == "exist")
                    {
                        var str = arr2[1].Split(')')[0];
                        var tempArr = str.Split('[');
                        selector = tempArr[0];
                        attribute = tempArr[1].Trim(']');
                        var exist = dict.ContainsKey(selector) && dict[selector].AllKeys.Contains(attribute);
                        value = exist.ToString();
                    }
                }
                else
                {
                    //高级属性
                    attribute = arr3[1].Trim(']');
                    var index1 = arr3.Length > 2 ? int.Parse(arr3[2].Trim(']')) : 0;
                    var index2 = 0;
                    var index3 = 0;

                    if (arr2.Length > 1)
                    {
                        var arr4 = arr2[1].Split(',');
                        index2 = int.Parse(arr4[0]);
                        index3 = arr4.Length > 1 ? int.Parse(arr4[1].Trim(')')) : 0;
                    }

                    //取值
                    if (dict.ContainsKey(selector) && dict[selector].AllKeys.Contains(attribute))
                    {
                        value = dict[selector][attribute];
                        if (value.IndexOf('(') > -1)
                        {
                            value = value.Split('(')[1].Split(')')[0].Split(',')[index2];
                            value = value.Split(' ')[index3];
                        }
                        value = value.Split(' ')[index1];
                    }
                    else
                    {
                        //未配置
                    }
                }

                dictVariable[name]=value;
                stringBuilder.AppendFormat("{0}:{1};\r\n", name, value);
            }

            //处理$when关键字判断
            var content = response.Content;
            var pattern = @"\$when\(@([a-zA-z][a-zA-z0-9]*)=(.*?)(\r\n)?\|(\r\n)?(.*?)(\r\n)?\|(\r\n)?(.*?)\)(?!\))";
            var matches = Regex.Matches(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            foreach(Match m in matches)
            {
                var variable = m.Groups[1].Value.Trim();
                var compares = m.Groups[2].Value.Trim();
                var variableValue = dictVariable.ContainsKey(variable) ? dictVariable[variable] : string.Empty;
                var values = compares.Split(',');
                var finds = values.Where(x=>x.Trim()==variableValue);
                //var result = finds.Count()>0 ? m.Groups[3].Value : m.Groups[4].Value;
                var result = finds.Count() > 0 ? m.Groups[5].Value : m.Groups[8].Value;
                content = content.Replace(m.Value, result);
            }

            //处理@theme变量替换
            content = content.Replace("@theme", _theme);

            //添加easyui变量
            content = stringBuilder.ToString() + content;
          
            //返回结果
            response.Content = content;
            response.ContentType = "text/css";
        }
    }
}