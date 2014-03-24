using System.Collections.Specialized;
using System.Web.Mvc;
using Newtonsoft.Json;
using Zephyr.Core;

namespace Zephyr.Web.Mvc.Controllers
{
    [MvcMenuFilter(false)]
    [WebFrameworkFilter]
    public class PluginsController : Controller
    {
        //
        // GET: /Plugins/

        public ActionResult Lookup()
        {
            return View();
        }

        public ActionResult GetLookupData(string index)
        {
            var type = Request.QueryString["_lookupType"].Split('.');

            var xmlPath = string.Empty; 
            if (type.Length > 1)
                xmlPath = string.Format("~/Areas/{0}/Views/Shared/Xml/{1}.xml", type);
            else
                xmlPath = string.Format("~/Views/Shared/Xml/{0}.xml", type[type.Length - 1]);
 
            var wrapper = RequestWrapper.InstanceRequest().LoadXmlFile(xmlPath);

            var pQuery =wrapper.ToParamQuery();
            var data = wrapper.GetService().GetDynamicListWithPaging(pQuery);
 
            var json = JsonConvert.SerializeObject(data);
            return Content(json, "application/json");
        }
    }
}
