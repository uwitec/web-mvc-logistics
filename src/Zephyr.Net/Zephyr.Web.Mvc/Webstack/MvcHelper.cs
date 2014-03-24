using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Zephyr.Core;
using Zephyr.Utils;

namespace Zephyr.Web.Mvc
{
    public class MvcHelper
    {
        public static string GetCookies(string name) 
        {
            var cookie = HttpContext.Current.Request.Cookies.Get(name);
            return cookie == null ? null : cookie.Value;
        }

        public static LoginerBase GetLoginer()
        {
            return FormsAuth.GetLoginer();
        }
 
        public static void ThrowHttpExceptionWhen(bool condition,string message,params object[] param)
        {
            if (condition)
                throw new HttpResponseException(new HttpResponseMessage() { Content = new StringContent(string.Format(message,param)) });
        }
    }
}