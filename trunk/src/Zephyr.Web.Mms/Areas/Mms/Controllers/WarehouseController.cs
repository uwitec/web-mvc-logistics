using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mms.Controllers
{
    public class WarehouseController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }
    }

    public class WarehouseApiController : ApiController
    {
        public dynamic Get(RequestWrapper request)
        {
            request.SetXml(@"
<settings>
    <where>
        <c column='ProjectCode' symbol='equal' ignore='empty'></c>
    </where>
    <orderby>WarehouseCode</orderby>
</settings>");
            var service = new mms_warehouseService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode(string id)
        {
            var service = new mms_warehouseService();
            return service.GetNewKey("WarehouseCode", "maxplus").PadLeft(3, '0');
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>mms_warehouse</table>
    <where>
        <c column='WarehouseCode' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_warehouseService();
            var result = service.Edit(data,null,tabsWrapper); 
        }
    }
}
