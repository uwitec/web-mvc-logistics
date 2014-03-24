using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Zephyr.Web.Mvc
{
    public class WebFrameworkFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AppSettings.Entrance.OnFrameworkActionExecuting(filterContext);
        }
    }
}