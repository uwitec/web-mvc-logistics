using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Optimization;
using Zephyr.Utils;

namespace Zephyr.Web.Mvc
{
    public class BundleConfigBase
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            ResetIgnorePatterns(bundles.IgnoreList);
 
            //@Script.Render("~/Resource/...");
            BundleTable.VirtualPathProvider = new ResourceVirtualPathProvider(HostingEnvironment.VirtualPathProvider);
         
            //脚本
            bundles.Add(new ScriptBundle("~/Content/js/librarys").Include(
                "~/Content/js/library/json2.min.js",
                "~/Content/js/core/utils.js",
                "~/Content/js/core/common.js",
                string.Format("~/Content/js/knockout/knockout-{0}.js",AppSettings.KnockoutVersion),
                "~/Content/js/knockout/knockout.mapping-2.4.1.js",
                "~/Content/js/knockout/knockout.bindings.js",
                "~/Content/js/jquery-plugins/showloading/jquery.showLoading.min.js",
                "~/Content/js/easyui/easyuifix.js"));

            bundles.Add(new ScriptBundle("~/Content/js/index").Include(
                string.Format("~/Content/js/jquery/jquery-{0}.min.js",AppSettings.JqueryVersion),
                "~/Content/js/library/json2.min.js",
                "~/Content/js/jquery-extend/jquery.cookie.js",
                "~/Content/js/core/utils.js",
                "~/Content/js/core/common.js",
                "~/Content/js/easyui/easyuifix.js",
                "~/Content/js/jquery-plugins/jnotify/jquery.jnotify.js",
                "~/Content/js/jquery-plugins/showloading/jquery.showLoading.min.js",
                "~/Content/js/jquery-plugins/ztree/3.5/jquery.ztree.all-3.5.min.js",
                "~/Content/js/viewmodels/index.js"));

            //样式
            bundles.Add(new StyleBundle("~/Content/css/index").Include(
                   "~/Content/css/960/fluid/reset.css",
                   "~/Content/css/960/fluid/text.css",
                   "~/Content/css/960/fluid/grid.css",
                   "~/Content/css/base.css",
                   "~/Content/css/hack/fix.css",
                   "~/Content/css/page/index.css"
               ));

            bundles.Add(new StyleBundle("~/Content/css/base").Include(
                   "~/Content/css/960/fluid/reset.css",
                   "~/Content/css/960/fluid/text.css",
                   "~/Content/css/960/fluid/grid.css",
                   "~/Content/css/base.css",
                   "~/Content/css/hack/ie.css",
                   "~/Content/css/hack/fix.css"
               ));
 
            var dirbase = new DirectoryInfo(HttpContext.Current.Server.MapPath(
                string.Format("~/Content/js/easyui/{0}/themes",AppSettings.EasyuiVersion)));
            DirectoryInfo[] dirs = dirbase.GetDirectories();
            foreach (var dir in dirs)
            {
                if (dir.Name == "icons") continue;
                var theme = dir.Name;
                var themeBundle = new Bundle(string.Format("~/Content/css/theme/{0}", theme)).Include(
                    "~/Content/css/less/elements.less", 
                    "~/Content/css/less/theme.css");
                themeBundle.Transforms.Add(new EasyuiLessTransform(theme));
                themeBundle.Transforms.Add(new LessTransform());
                themeBundle.Transforms.Add(new CssMinify());
                bundles.Add(themeBundle);
            }
        }

        public static void ResetIgnorePatterns(IgnoreList ignoreList)
        {
            ignoreList.Clear();
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}