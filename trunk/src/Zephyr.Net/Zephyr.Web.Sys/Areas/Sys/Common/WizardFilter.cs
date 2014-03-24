using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Zephyr.Web.Sys
{
    public class WizardFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!DbCreatorBase.IsCanInitDb || !DbCreatorBase.IsNeedToInitDb)
                filterContext.Result = new RedirectResult("/");
        }
    }
}