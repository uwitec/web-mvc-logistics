using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zephyr.Core;
using Zephyr.Data;
using Zephyr.Utils;
using Zephyr.Web.Mvc;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace System.Web.Mvc
{
    public class AppSettings : App
    {
        public static IWebEntrance Entrance = new DefaultWebEntrance();
        public static Dictionary<string, string> DefaultUserSettings = GetDefaultUserSettings();
        public static Dictionary<string, string> DefaultUserSettingDesc = GetDefaultUserSettingDesc();
        public static string EasyuiVersion ="1.3.4";        // 1.3.2
        public static string JqueryVersion = "1.10.2";      // 1.8.1
        public static string KnockoutVersion = "3.0.0";     // 2.2.1

        private static Dictionary<string, string> GetDefaultUserSettings()
        {
            var result = new Dictionary<string, string>();
            result["homeTabTitle"] = "我的桌面";
            result["homeTabUrl"] = "/home/welcome";
            result["maxTabCount"] = "10";
            result["navigation"] = "accordion";
            result["gridrows"] = "20";
            result["locale"] = "zh_CN";
            result["theme"] = "default";
   
            return result;
        }

        private static Dictionary<string, string> GetDefaultUserSettingDesc()
        {
            var result = new Dictionary<string, string>();
            result["homeTabTitle"] = "主页签的名称";
            result["homeTabUrl"] = "主页签的页面路径";
            result["maxTabCount"] = "页签数据超过后会提醒";
            result["navigation"] = "导航栏类型";
            result["gridrows"] = "每页显示的数据条数";
            result["locale"] = "语言";
            result["theme"] = "主题风格";

            return result;
        }
    }
}