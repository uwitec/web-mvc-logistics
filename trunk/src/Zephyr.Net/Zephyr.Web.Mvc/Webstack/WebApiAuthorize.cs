using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using Zephyr.Core;

namespace Zephyr.Web.Mvc
{
    public class WebApiAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            if (!base.IsAuthorized(actionContext))
                return false;

            if (!FormsAuth.ValidateToken())
                return false;

            return true;
        }
    }     
}