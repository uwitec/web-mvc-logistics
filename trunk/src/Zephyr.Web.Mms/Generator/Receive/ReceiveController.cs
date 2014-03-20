using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Areas.Mms.Controllers
{
    public class ReceiveController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = new {
                    query = "/api/Mms/Receive",
                    remove = "/api/Mms/Receive/",
                    billno = "/api/Mms/Receive/getnewbillno",
                    audit = "/api/Mms/Receive/audit/",
                    edit = "/Mms/Receive/edit/"
                },
                resx = new {
                    detailTitle = "单据明细",
                    noneSelect = "请先选择一条单据！",
                    deleteConfirm = "确定要删除选中的单据吗？",
                    deleteSuccess = "删除成功！",
                    auditSuccess = "单据已审核！"
                },
                dataSource = new{
                    //dsPurpose = new sys_codeService().GetValueTextListByType("Purpose")
                },
                form = new{
                    BillNo = "" ,
                    BillDate = "" ,
                    ProjectCode = "" ,
                    DoPerson = "" ,
                    SupplierCode = "" ,
                    ReceiveDate = "" 
                },
                idField="BillNo"
            };

            return View(model);
        }
    }

    public class ReceiveApiController : ApiController
    {
        

        public string GetNewBillNo()
        {
            return new mms_receiveService().GetNewKey("BillNo", "dateplus");
        }

        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>mms_receive</from>
    <where>
        <c column='BillNo'		symbol='equal' ignore='empty'></c>   
        <c column='BillDate'		symbol='equal' ignore='empty'></c>   
        <c column='ProjectCode'		symbol='equal' ignore='empty'></c>   
        <c column='DoPerson'		symbol='equal' ignore='empty'></c>   
        <c column='SupplierCode'		symbol='equal' ignore='empty'></c>   
        <c column='ReceiveDate'		symbol='equal' ignore='empty'></c>   
    </where>
    <orderby>BillNo</orderby>
</settings>");
            var service = new mms_receiveService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}