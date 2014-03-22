using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json.Linq;

namespace Zephyr.Web.Mvc
{
    public class RouteConfigBase
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //调整route顺序
            var tempRoutes = new List<RouteBase>();
            foreach (var item in routes.Where(r => r.GetType() == typeof(Route)))
            {
                var url = (item as Route).Url.Trim('/');
                if (url.Split('/')[0].IndexOf("{") >= 0)
                    tempRoutes.Add(item);
            }
            
            routes.MapPageRoute("Report", "report", "~/Content/page/report.aspx");
 
            routes.MapRoute(
                name: "Resource",
                url: "Resource/{assemblyName}/{*fileName}",
                defaults: new { controller = "Resource", action = "Index" },
                namespaces: new string[] { "Zephyr.Web.Mvc.Controllers" }
            );
 
            routes.MapRoute(
                name: "WebMvcDefault",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Zephyr.Web.Mvc.Controllers" }
            );

            foreach (var item in tempRoutes)
            {
                routes.Remove(item);
                routes.Add(item);
            }
 
            ModelBinders.Binders.Add(typeof(JObject), new JObjectModelBinder()); //for dynamic model binder
        }
    }
}