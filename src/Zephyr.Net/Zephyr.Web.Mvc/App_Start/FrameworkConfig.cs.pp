using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Data;
//using Zephyr.Web.Sys;

namespace $rootnamespace$
{
    public class FrameworkConfig
    {
        public static void Register()
        {
            App.OnDbExecuting = OnDbExecuting;
            App.FormAuthTokenType = "ipadress";
            //FrameworkConfigBase.Entrance = new SysEntrance();
        }

        private static void OnDbExecuting(CommandEventArgs args)
        {
            var sql = args.Command.CommandText;
        }
    }
}