
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mms;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms.Controllers
{
    public class ProductTestController : Controller
    {
        public ActionResult Index()
        {
            var code = new sys_codeService();
            var model = new
            {
                dataSource = new{
                    dsPricing = code.GetValueTextListByType("Pricing")
                },
                urls = new{
                    query = "/api/mms/ProductTest",
                    newkey = "/api/mms/ProductTest/getnewkey",
                    edit = "/api/mms/ProductTest/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    ProductName = "" ,
                    ProductCode = "" ,
                    ProductColor = "" ,
                    ProductType = "" ,
                    ProductDate = "" 
                },
                defaultRow = new {
                   
                },
                setting = new{
                    idField = "ID",
                    postListFields = new string[] { "ID" ,"ProductName" ,"ProductCode" ,"ProductColor" ,"ProductType" ,"ProductDate" ,"Qty" ,"Money" }
                }
            };

            return View(model);
        }

    }

    public class ProductTestApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>mms_productTest</from>
    <where>
        <c column='ProductName'	 ignore='empty'	cp='like'></c>   
        <c column='ProductCode'	 ignore='empty'	cp='startwith'></c>   
        <c column='ProductColor' ignore='empty' cp='equal'></c>   
        <c column='ProductType'	 ignore='empty'	cp='equal'></c>   
        <c column='ProductDate'	 ignore='empty'	cp='daterange'></c>   
    </where>
    <orderby>ID</orderby>
</settings>");
            var service = new mms_productTestService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new mms_productTestService().GetNewKey("ID", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        mms_productTest
    </table>
    <where>
        <c column='ID' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_productTestService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
