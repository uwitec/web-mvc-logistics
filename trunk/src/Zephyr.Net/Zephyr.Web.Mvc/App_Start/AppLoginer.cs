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
    public class AppLoginer
    {
        public static string UserCode { get { return HttpContext.Current.User.Identity.Name; } }
        public static string UserName { get { return FormsAuth.GetLoginer().UserName; } }
        public static string Locale { get { return GetSetting("locale"); } }
        public static string Theme { get { return GetSetting("theme"); } }
        public static string Navigation { get { return GetSetting("navigation"); } }
        public static string GridRows { get { return GetSetting("gridrows"); } }
        public static string HomeTabTitle { get { return GetSetting("homeTabTitle"); } }
        public static string HomeTabUrl { get { return GetSetting("homeTabUrl"); } }
        public static string MaxTabCount { get { return GetSetting("maxTabCount"); } }
 
        public static string GetSetting(string name)
        {
            var settings = GetSettings();
            if (settings != null && settings.ContainsKey(name))
                return settings[name];

             return AppSettings.DefaultUserSettings.ContainsKey(name)?
                AppSettings.DefaultUserSettings[name]:string.Empty;
        }

        public static void Clear()
        {
            var sessionKey = "__settings__";
            var sessionEnabled = HttpContext.Current.Session != null;
            if (sessionEnabled)
                SessionHelper.Remove(sessionKey);
        }

        public static Dictionary<string, string> GetSettings()
        {
            var sessionKey = "__settings__";
            var sessionEnabled = HttpContext.Current.Session != null;
            Dictionary<string, string> settings;

            if (sessionEnabled)
            {
                settings = SessionHelper.Get(sessionKey) as Dictionary<string, string>;
                if (settings == null)
                {
                    settings = AppSettings.Entrance.GetCurrentUserSettings();
                    SessionHelper.Add(sessionKey, settings);
                }
            }
            else
            {
                settings = AppSettings.Entrance.GetCurrentUserSettings();
            }

            return settings;
        }
    }
}