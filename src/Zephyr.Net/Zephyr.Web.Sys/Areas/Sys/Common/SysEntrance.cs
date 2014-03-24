using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Mvc;
using System.Web.Mvc;
using Zephyr.Utils;

namespace Zephyr.Web.Sys
{
    public class SysEntrance : IWebEntrance
    {
        public virtual Dictionary<string, string> GetCurrentUserSettings()
        {
            return new sys_userService().GetCurrentUserSettings();
        }

        public virtual List<dynamic> GetUserMenus()
        {
            return new sys_menuService().GetUserMenu(FormsAuth.GetLoginer().UserCode);
        }
 
        public virtual object LoginHandler(JObject request)
        {
            return new sys_userService().Login(request);
        }

        public virtual object ChangePassword(string passwordold, string passwordnew)
        {
            var message = new sys_userService().ChangePassword(passwordold, passwordnew);
            return string.IsNullOrEmpty(message) ? 
                new { status = "success", message = "修改成功" } : 
                new { status = "error", message = message };
        }

        public virtual void Logger(string position, string target, string type, object message)
        {
            var service = new sys_logService();
            service.LoggerOperation(position, target, type, message);
        }

        public virtual void OnFrameworkActionExecuting(ActionExecutingContext filterContext)
        {
            var route = filterContext.RouteData.Values;
            var controllerName = route["controller"].ToString().ToLower();
            var actionName = route["action"].ToString().ToLower();

            if ((controllerName == "home" && actionName == "index") ||
                (controllerName == "login" && actionName == "index"))
            {
                if (DbCreatorBase.IsNeedToInitDb && DbCreatorBase.IsCanInitDb)
                    filterContext.Result = new RedirectResult("/sys/wizard");
            }
        }

        public virtual bool AuthorizeUserMenu(List<string> urls)
        {
            return new sys_userService().AuthorizeUserMenu(urls);
        }

        public virtual string GetParameter(string name)
        {
            var pQuery = ParamQuery.Instance().Select("ParamValue").Where("ParamCode", name);
            return new sys_parameterService().GetField<string>(pQuery);
        }
    }
}