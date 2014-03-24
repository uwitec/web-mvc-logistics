using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Zephyr.Core;

namespace Zephyr.Web.Mvc
{
    public class MvcAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase context)
        {
            if (!base.AuthorizeCore(context))
                return false;

            if (!FormsAuth.ValidateToken())
                return false;

            return true;
        }
    }     
}