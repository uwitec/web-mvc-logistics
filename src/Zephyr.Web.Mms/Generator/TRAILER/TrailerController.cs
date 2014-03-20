using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Web.Mvc;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Trade.Models;

namespace Zephyr.Web.Trade.Controllers
{
    public class TrailerController : Controller
    {
        public ActionResult Edit(string id = "")
        {

            var model = new
            {
                urls = new {
                    getdata = "/api/Trade/Trailer/GetPageData/",        //获取主表数据及数据滚动数据api
                    edit = "/api/Trade/Trailer/edit/",                      //数据保存api
                    audit = "/api/Trade/Trailer/audit/",                    //审核api
                    newkey = "/api/Trade/Trailer/GetNewRowId/"            //获取新的明细数据的主键(日语叫采番)
                },
                resx = new {
                    rejected = "已撤消修改！",
                    editSuccess = "保存成功！",
                    auditPassed ="单据已通过审核！",
                    auditReject = "单据已取消审核！"
                },
                dataSource = new{
                    pageData=new TrailerApiController().GetPageData(id)
                    //payKinds = codeService.GetValueTextListByType("PayType")
                },
                form = new{
                    defaults = new trade_trailer().Extend(new {  JOBNO = "",TR_JOBNOIN = "",TR_IEID = "",TR_BLNO = "",TR_CONNO = "",TR_SEALNO = "",TR_CARRICD = "",TR_CARRI = "",TR_CARNO = "",TR_ETSH = "",TR_TYPE = "",TR_SPTYPE = "",TR_STATUS = ""}),
                    primaryKeys = new string[]{"JOBNO"}
                },
                tabs = new object[]{
                    new{
                      type = "grid",
                      rowId = "SNO",
                      relationId = "JOBNO",
                      postFields = new string[] { "SNO","SC_DRIVERCD","SC_DRIVER","SC_TRUCKCD","SC_TRUCKNAME","SC_FRAMECD","SC_FRAMENO","SC_DRIVERTEL","SC_STARTDATE"},
                      defaults = new {SNO = "",SC_DRIVERCD = "",SC_DRIVER = "",SC_TRUCKCD = "",SC_TRUCKNAME = "",SC_FRAMECD = "",SC_FRAMENO = "",SC_DRIVERTEL = "",SC_STARTDATE = ""}
                    }    
                }
            };
            return View(model);
        }
    }

    public class TrailerApiController : ApiController
    {
        public dynamic GetPageData(string id)
        {
            var masterService = new trade_trailerService();
            var pQuery = ParamQuery.Instance().Where("JOBNO", id);

             var result = new {
                //主表数据
                form = masterService.GetModel(pQuery),
                scrollKeys = masterService.ScrollKeys("JOBNO", id),

                //明细数据
                tab0 = new trade_schedulerService().GetDynamicList(pQuery)
            };
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Audit(string id, JObject data)
        {
            var pUpdate = ParamUpdate.Instance()
                .Update("trade_trailer")
                .Column("ApproveState", data["status"])
                .Column("ApproveRemark", data["comment"])
                .Column("ApprovePerson", FormsAuth.GetLoginer().UserName)
                .Column("ApproveDate", DateTime.Now)
                .Where("JOBNO", id);

            var service = new trade_trailerService();
            var rowsAffected = service.Update(pUpdate);
            MvcHelper.ThrowHttpExceptionWhen(rowsAffected < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
  
        //todo 改成支持多个Tab
        // 地址：GET api/mms/@(controller)/getnewrowid 预取得新的明细表的行号
        public string GetNewRowId(string type,string key,int qty=1)
        {
            switch (type)
            {
                case "grid0":
                    var service0 = new trade_schedulerService();
                    return service0.GetNewKey("SNO", "maxplus", qty, ParamQuery.Instance().Where("JOBNO", key));
                default:
                    return "";
            }
        }
  
        // 地址：POST api/mms/send 功能：保存收料单数据
        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        trade_trailer
    </table>
    <where>
        <c column='JOBNO' symbol='equal'></c>
    </where>
</settings>");

            var tabsWrapper = new List<RequestWrapper>();
            tabsWrapper.Add(RequestWrapper.Instance().SetXml(@"
<settings>
    <table>trade_scheduler</table>
    <where>
        <c column='JOBNO' symbol='equal'></c>      
        <c column='SNO' symbol='equal'></c>      
    </where>
</settings>"));
             
            var service = new trade_trailerService();
            var result = service.Edit(data, formWrapper, tabsWrapper);
        }
    }
}