using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mms.Controllers
{
    [MvcMenuFilter(false)]
    public class HomeController : Controller
    {
        //
        // GET: /MMS/Home/
        [System.Web.Mvc.AllowAnonymous]
        public ActionResult Desktop()
        {
            if (!User.Identity.IsAuthenticated)
                return Redirect("~/Login/mms");

            return View();
        }

        public ActionResult LookupMaterial()
        {
            return View();
        }
    }

    public class HomeApiController : ApiController
    {
        //弹出材料选择窗口数据
        public dynamic GetMaterial(RequestWrapper request)
        {
            var service = new mms_materialService();
            return service.GetDynamicListWithPaging(request.ToParamQuery());
        }

        //弹出材料选择窗口数据
        public dynamic GetMaterialType()
        {
            var service = new mms_materialTypeService();
            var requst = RequestWrapper.InstanceRequest()
                .SetXml(@"
<settings>
    <select>MaterialTypeName as text,MaterialType as id,ParentCode as pid</select>
    <from>mms_materialType</from>
    <orderby>MaterialType</orderby>
</settings>");
 
            var pQuery = requst.ToParamQuery();
            return service.GetDynamicList(pQuery);
        }
    }
}
