using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mms
{
    public class SysAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Mms";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: this.AreaName + "default",
                url: this.AreaName + "/{controller}/{action}/{id}",
                defaults: new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Zephyr.Web." + this.AreaName + ".Controllers" }
            );

            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                name: this.AreaName + "Api",
                routeTemplate: "api/" + this.AreaName + "/{controller}/{action}/{id}",
                defaults: new { area = this.AreaName, action = RouteParameter.Optional, id = RouteParameter.Optional, namespaceName = new string[] { string.Format("Zephyr.Web.{0}.Controllers", this.AreaName) } },
                constraints: new { action = new StartWithConstraint() }
            );
        }
    }
}
