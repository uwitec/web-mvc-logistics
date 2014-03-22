using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using System.Web.Optimization;
using System.Linq;
using RazorGenerator.Mvc;
using Zephyr.Core;
using System.Web.Routing;
using System.Web.Http;
using System.Collections.Generic;
 
[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Zephyr.Web.Mvc.App_Start.RazorGeneratorMvcStart), "Start")]

namespace Zephyr.Web.Mvc.App_Start {
    public static class RazorGeneratorMvcStart {
        public static void Start() {
            var engine = new PrecompiledMvcEngine(typeof(RazorGeneratorMvcStart).Assembly) {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            };

            ViewEngines.Engines.Insert(0, engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);

            // ³õÊ¼»¯¿ò¼Ü 
            App.Init();
            App.OperationLogger = (position, target, type, message) => AppSettings.Entrance.Logger(position, target, type, message);

            WebApiConfigBase.Register(GlobalConfiguration.Configuration);
            FilterConfigBase.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfigBase.RegisterRoutes(RouteTable.Routes);
            BundleConfigBase.RegisterBundles(BundleTable.Bundles);
        }
    }
}
