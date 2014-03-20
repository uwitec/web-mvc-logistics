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

namespace Zephyr.Areas.Mms.Controllers
{
    public class DealController : Controller
    {
        public ActionResult Edit(string id = "")
        {

            var model = new
            {
                urls = new {
                    getdata = "/api/Mms/Deal/GetPageData/",        //获取主表数据及数据滚动数据api
                    edit = "/api/Mms/Deal/edit/",                      //数据保存api
                    audit = "/api/Mms/Deal/audit/",                    //审核api
                    newkey = "/api/Mms/Deal/GetNewRowId/"            //获取新的明细数据的主键(日语叫采番)
                },
                resx = new {
                    rejected = "已撤消修改！",
                    editSuccess = "保存成功！",
                    auditPassed ="单据已通过审核！",
                    auditReject = "单据已取消审核！"
                },
                dataSource = new{
                    pageData=new DealApiController().GetPageData(id)
                    //payKinds = codeService.GetValueTextListByType("PayType")
                },
                form = new{
                    defaults = new mms_deal().Extend(new {  DoPerson = "",ApplyDate = "",DealType = "",TotalMoney = "",ApproveState = ""}),
                    primaryKeys = new string[]{"BillNo"}
                },
                tabs = new object[]{
                    new{
                      type = "form",
                      primaryKeys = new string[]{"BillNo"},
                      defaults = new {ApproveState = "",ApproveRemark = "",ApprovePerson = "",ApproveDate = "",CreatePerson = "",CreateDate = "",UpdatePerson = "",UpdateDate = ""}
                    },    
                    new{
                      type = "grid",
                      rowId = "RowId",
                      relationId = "BillNo",
                      postFields = new string[] { "BillNo","Unit","ExpendCompany","UnitPrice","Money","CreateDate","UpdatePerson"},
                      defaults = new {BillNo = "",Unit = "",ExpendCompany = "",UnitPrice = "",Money = "",CreateDate = "",UpdatePerson = ""}
                    }    
                }
            };
            return View(model);
        }
    }

    public class DealApiController : ApiController
    {
        public dynamic GetPageData(string id)
        {
            var masterService = new mms_dealService();
            var pQuery = ParamQuery.Instance().Where("BillNo", id);

             var result = new {
                //主表数据
                form = masterService.GetModel(pQuery),
                scrollKeys = masterService.ScrollKeys("BillNo", id),

                //明细数据
                tab0 = new mms_dealService().GetModel(pQuery),      
                tab1 = new mms_dealDetailService().GetDynamicList(pQuery)
            };
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Audit(string id, JObject data)
        {
            var pUpdate = ParamUpdate.Instance()
                .Update("mms_deal")
                .Column("ApproveState", data["status"])
                .Column("ApproveRemark", data["comment"])
                .Column("ApprovePerson", FormsAuth.GetLoginer().UserName)
                .Column("ApproveDate", DateTime.Now)
                .Where("BillNo", id);

            var service = new mms_dealService();
            var rowsAffected = service.Update(pUpdate);
            MvcHelper.ThrowHttpExceptionWhen(rowsAffected < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
  
        //todo 改成支持多个Tab
        // 地址：GET api/mms/@(controller)/getnewrowid 预取得新的明细表的行号
        public string GetNewRowId(string type,string key,int qty=1)
        {
            switch (type)
            {
                case "grid1":
                    var service1 = new mms_dealDetailService();
                    return service1.GetNewKey("RowId", "maxplus", qty, ParamQuery.Instance().Where("BillNo", key));
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
        mms_deal
    </table>
    <where>
        <c column='BillNo' symbol='equal'></c>
    </where>
</settings>");

            var tabsWrapper = new List<RequestWrapper>();
            tabsWrapper.Add(RequestWrapper.Instance().SetXml(@"
<settings>
    <table>mms_deal</table>
    <where>
        <c column='BillNo' symbol='equal'></c>
    </where>
</settings>"));
            tabsWrapper.Add(RequestWrapper.Instance().SetXml(@"
<settings>
    <table>mms_dealDetail</table>
    <where>
        <c column='BillNo' symbol='equal'></c>      
        <c column='RowId' symbol='equal'></c>      
    </where>
</settings>"));
             
            var service = new mms_dealService();
            var result = service.EditPage(data, formWrapper, tabsWrapper);
        }
    }
}