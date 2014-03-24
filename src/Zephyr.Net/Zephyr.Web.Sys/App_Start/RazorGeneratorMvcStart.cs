using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.WebPages;
using RazorGenerator.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Zephyr.Web.Sys.App_Start.RazorGeneratorMvcStart), "Start")]

namespace Zephyr.Web.Sys.App_Start {
    public static class RazorGeneratorMvcStart {
        public static void Start() {
            var engine = new PrecompiledMvcEngine(typeof(RazorGeneratorMvcStart).Assembly) {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            };

            ViewEngines.Engines.Insert(0, engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);

            // regist bundles
            var jsList = new string[] { 
                "Code.js",
                "Config.js",
                "Generator.js",
                "Menu.js",
                "Organize.js",
                "Parameter.js",
                "Permission.js",
                "Role.js",
                "User.js"
            };

            foreach (var js in jsList)
                BundleTable.Bundles.Add(new ScriptBundle("~/Resource/Sys/" + js).Include("~/Resource/Zephyr.Web.Sys/Areas/Sys/ViewModels/" + js));

            App.GetDefaultConnectionName = DbCreatorBase.GetDefaultConnectionName;
            if (AppSettings.Entrance.GetType() == typeof(DefaultWebEntrance))
                AppSettings.Entrance = new SysEntrance();
        }
    }
}
