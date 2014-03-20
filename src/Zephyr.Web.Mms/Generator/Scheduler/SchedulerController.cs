using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Trade.Models;

namespace Zephyr.Web.Trade.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = new {
                    query = "/api/Trade/Scheduler",
                    remove = "/api/Trade/Scheduler/",
                    billno = "/api/Trade/Scheduler/getnewbillno",
                    audit = "/api/Trade/Scheduler/audit/",
                    edit = "/Trade/Scheduler/edit/"
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
                    JOBNO = "" ,
                    SNO = "" ,
                    SC_DRIVER = "" ,
                    SC_TRUCKCD = "" ,
                    SC_DISTANCEID = "" ,
                    SC_ONCNTDATE = "" ,
                    SC_ARRIVEDATE = "" 
                },
                idField="JOBNO"
            };

            return View(model);
        }
    }

    public class SchedulerApiController : ApiController
    {
        

        public string GetNewBillNo()
        {
            return new trade_schedulerService().GetNewKey("JOBNO", "dateplus");
        }

        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>trade_scheduler</from>
    <where>
        <c column='JOBNO'		symbol='equal' ignore='empty'></c>   
        <c column='SNO'		symbol='equal' ignore='empty'></c>   
        <c column='SC_DRIVER'		symbol='equal' ignore='empty'></c>   
        <c column='SC_TRUCKCD'		symbol='equal' ignore='empty'></c>   
        <c column='SC_DISTANCEID'		symbol='equal' ignore='empty'></c>   
        <c column='SC_ONCNTDATE'		symbol='equal' ignore='empty'></c>   
        <c column='SC_ARRIVEDATE'		symbol='equal' ignore='empty'></c>   
    </where>
    <orderby>JOBNO</orderby>
</settings>");
            var service = new trade_schedulerService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}