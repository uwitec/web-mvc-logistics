using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Zephyr.Utils;

namespace Zephyr.Web.Mvc.Controllers
{
    [AllowAnonymous]
    [MvcMenuFilter(false)]
    [WebFrameworkFilter]
    public class ResourceController : Controller
    {
        public ActionResult Index()
        {
            var assemblyName = ResourceVirtualPathProvider.ResourceVirtualPath.GetAssemblyName(Request.Path);
            var filename = ResourceVirtualPathProvider.ResourceVirtualPath.GetResourceName(Request.Path);
            var assembly = ReflectionHelper.GetAssembly(assemblyName);

            var stream = ResourceHelper.GetFileStream(assembly,filename);
            var contentType = ResourceHelper.GetContentType(filename);

            if (stream == null)
                return HttpNotFound();

            return File(stream, contentType);
        }
    }
}
