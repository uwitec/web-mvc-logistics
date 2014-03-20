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
    public class MerchantController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }
    }

    public class MerchantApiController : ApiController
    {
        /// <summary>
        /// 地址：GET api/mms/merchant/getnames
        /// 功能：取得收料单供应商
        /// 调用：供应商自动完成
        /// </summary>
        public List<dynamic> GetNames(string q)
        {
            var ReceiveService = new mms_merchantsService();
            var pQuery = ParamQuery.Instance().Select("top 10 MerchantsName").Where(c=>c.And("MerchantsName",q).Symbol("StartWithPY"));
            return ReceiveService.GetDynamicList(pQuery);
        }

        public dynamic GetTypes(RequestWrapper request)
        {
            request.SetXml(@"
<settings>
   <where>
        <c column='MerchantsTypeCode'      symbol='equal' ignore='empty'></c>
        <c column='MerchantsTypeName'      symbol='like'  ignore='empty'></c>
    </where>
    <orderby>MerchantsTypeCode</orderby>
</settings>
");
            var result = new mms_merchantsTypeService().GetDynamicListWithPaging(request.ToParamQuery());
            return result;
        }

        public dynamic Get(RequestWrapper request)
        {
            request.SetXml(@"
<settings>
    <where>
        <c column='MerchantsTypeCode' symbol='equal' ignore='empty'></c>
    </where>
    <orderby>MerchantsCode</orderby>
</settings>");
            var service = new mms_merchantsService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode(string id)
        {
            var service = new mms_merchantsService();
            return service.GetNewKey("MerchantsCode", "maxplus").PadLeft(3, '0');
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>mms_merchants</table>
    <where>
        <c column='MerchantsCode' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_merchantsService();
            var result = service.Edit(data,null,tabsWrapper);
        }

        [System.Web.Http.HttpPost]
        public void EditType(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>mms_merchantsType</table>
    <where>
        <c column='MerchantsTypeCode' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_merchantsService();
            var result = service.Edit(data, null, tabsWrapper);
        }
    }
}
