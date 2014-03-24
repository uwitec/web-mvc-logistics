using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace System.Web.Mvc
{
    public static class StylesLess
    {
        public static IHtmlString Render(string path)
        {
            if (BundleTable.EnableOptimizations)
                return Styles.Render(path);

            var resolver = new BundleResolver(BundleTable.Bundles);
            var url = resolver.GetBundleUrl(path);
            var styles = string.Format("<link href=\"{0}\" rel=\"Stylesheet\"/>",url);
            return new MvcHtmlString(styles);
        }
    }
}