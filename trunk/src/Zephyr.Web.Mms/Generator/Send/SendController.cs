using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;

namespace Zephyr.Areas.Mms.Controllers
{
    public class SendController : Controller
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
                    query = "/api/Mms/Send",
                    newkey = "/api/Mms/Send/getnewkey",
                    edit = "/api/Mms/Send/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    BillNo = "" ,
                    BillDate = "" ,
                    DoPerson = "" ,
                    ProjectCode = "" ,
                    WarehouseCode = "" 
                },
                defaultRow = new {
                   
                },
                setting = new{
                    idField = "BillNo",
                    postListFields = new string[] { "BillNo" ,"BillDate" ,"MaterialType" ,"Purpose" ,"DoPerson" ,"ProjectCode" ,"WarehouseCode" ,"PickUnit" }
                }
            };

            return View(model);
        }
    }

    public class SendApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings >
    <select>*</select>
    <from>mms_send</from>
    <where>
        <c column='BillNo'		symbol='equal' ignore='empty'></c>   
        <c column='BillDate'		symbol='equal' ignore='empty'></c>   
        <c column='DoPerson'		symbol='equal' ignore='empty'></c>   
        <c column='ProjectCode'		symbol='equal' ignore='empty'></c>   
        <c column='WarehouseCode'		symbol='equal' ignore='empty'></c>   
    </where>
    <orderby>BillNo</orderby>
</settings>");
            var service = new mms_sendService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new mms_sendService().GetNewKey("BillNo", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        mms_send
    </table>
    <where>
        <c column='BillNo' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_sendService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}