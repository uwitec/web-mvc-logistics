using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Data;
using Zephyr.Utils;
using Zephyr.Web.Sys;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms
{
    public class FrameworkConfig
    {
        public static void Register()
        {
            AppSettings.OnDbExecuting = OnDbExecuting;
            AppSettings.Entrance = new MmsEntrance();
            AppSettings.FormAuthTokenType = "ipadress";
            AppSettings.JqueryVersion = "1.10.2";
            AppSettings.KnockoutVersion = "3.0.0";
            AppSettings.EasyuiVersion = "1.3.4";
        }

        private static void OnDbExecuting(CommandEventArgs args)
        {
            var sql = args.Command.CommandText;
        }
    }

    public class MmsEntrance : SysEntrance
    {
        public override object LoginHandler(JObject data)
        {
            var result = base.LoginHandler(data);
            var status = ReflectionHelper.GetPropertyValue(result, "status");
            if (status == "success")
                MmsService.LoginHandler(data);
            return result;
        }
    }
}