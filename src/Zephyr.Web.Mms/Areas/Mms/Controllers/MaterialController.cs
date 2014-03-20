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
    public class MaterialController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }
    }

    public class MaterialApiController : ApiController
    {
        public dynamic GetTypes(RequestWrapper request)
        {
            request.SetXml(@"
<settings>
   <where>
        <c column='MaterialType'       symbol='equal' ignore='empty'></c>
        <c column='MaterialsTypeName'  symbol='like'  ignore='empty'></c>
    </where>
    <orderby>MaterialType</orderby>
</settings>
");
            var result = new mms_materialTypeService().GetDynamicList(request.ToParamQuery());
            return result;
        }

        public dynamic Get(RequestWrapper request)
        {
            request.SetXml(@"
<settings>
   <where>
        <c column='MaterialType' symbol='equal' ignore='empty'></c>
    </where>
    <orderby>MaterialCode</orderby>
</settings>");
            var service = new mms_materialService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode(string id)
        {
            var service = new mms_materialService();
            return service.GetNewMaterialCode(id);
        }


        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>mms_material</table>
    <where>
        <c column='MaterialCode' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_materialService();
            var result = service.Edit(data,null,tabsWrapper);
        }

        [System.Web.Http.HttpPost]
        public void EditType(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>mms_materialType</table>
    <where>
        <c column='MaterialType' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_materialService();
            var result = service.Edit(data, null, tabsWrapper);
        }
    }
}
