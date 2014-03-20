using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Trade.Models;
using Newtonsoft.Json.Linq;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mms;

namespace Zephyr.Web.Trade.Controllers
{
    public class TrailerController : Controller
    {
        public ActionResult Index()
        {
            var code = new sys_codeService();
            var model = new
            {
                urls = TradeHelper.GetIndexUrls("trailer"),
                resx = TradeHelper.GetIndexResx("内贸订单"),

                dataSource = new{
                },

                /*
                urls = new{
                    query = "/api/Trade/Trailer",
                    remove = "/api/Trade/Trailer/",   
                    billno = "/api/Trade/Trailer/getnewjobo",
                    audit = "/api/Trade/Trailer/audit/",
                    edit = "/api/Trade/Trailer/edit/"
                },
                resx = new{
                    detailTitle = "内贸订单明细",
                    noneSelect = "请先选择一条内贸订单！",
                    deleteConfirm = "确定要删除选中的内贸订单吗？",
                    deleteSuccess = "删除成功！",
                    auditSuccess = "单据已审核！"
                },
                  
                 */

                form = new{
                    JOBNO = "",
                    TR_JOBNOIN = "" ,
                    TR_BLNO = "" ,
                    TR_CONNO = "" ,
                    TR_CARRI = "" ,
                    TR_CARNO = "" ,
                    TR_ETSH = "" 
                }

                /*
                ,
                defaultRow = new {
                   
                },
                setting = new{
                    //idField = "JOBNO",
                    postFormKeys = new string[] { "Jobno" },
                    postListFields = new string[] { "JOBNO", "SNO", "SC_DRIVERCD", "SC_DRIVER", "SC_TRUCKCD", "SC_TRUCKNAME", "SC_FRAMECD", "SC_FRAMENO", "SC_DRIVERTEL", "SC_STARTDATE"}
                }
                
                */ 
            };

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var userName = TradeHelper.GetUserName();
            var currentProject = TradeHelper.GetCurrentProject();
            var data = new TrailerApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = TradeHelper.GetEditUrls("trailer"),
                resx = TradeHelper.GetEditResx("内贸订单"),
                dataSource = new
                {
                },
                defaultForm = new trade_trailer().Extend(new
                {
                    JOBNO = id,
                    TR_ORDERDATE = DateTime.Now,
                }),
                defaultRow = new
                {
                    CheckNum = 1,
                    Num = 1,
                    UnitPrice = 0,
                    Money = 0,
                    PrePay = 0
                },
                setting = new
                {
                    postFormKeys = new string[] { "Jobno" },
                    postListFields = new string[] { "JOBNO", "SNO", "SC_DRIVERCD", "SC_DRIVER", "SC_TRUCKCD", "SC_TRUCKNAME", "SC_FRAMECD", "SC_FRAMENO", "SC_DRIVERTEL", "SC_STARTDATE" }
                }
            };
            return View(model);
        }
    }

    public class TrailerApiController : ApiController
    {
        trade_trailerService masterService = new trade_trailerService();
        trade_schedulerService detailService = new trade_schedulerService();
        string projectCode = TradeHelper.GetCurrentProject();

        #region 自动完成
        // GET api/trade/send/getbillno
        public virtual List<dynamic> GetJobno(string q)
        {
            var pQuery = ParamQuery.Instance().Select("top 10 Jobno").Where(c => c.And("Jobno", q).Symbol("StartWithPY"));
            return masterService.GetDynamicList(pQuery);
        }
        #endregion

        #region 采播
        // 取得新的主表Trailer GET api/trade/send/getnewjobno
        public virtual string GetNewJobno()
        {
            return masterService.GetNewKey("Jobno", "dateplus");
        }

        // 取得新的明细表SNO GET api/trade/send/getnewrowid
        public virtual string GetNewRowId(int id, string Jobno)
        {
            return detailService.GetNewKey("SNO", "maxplus", id, ParamQuery.Instance().Where("Jobno", Jobno));
        }
        #endregion

        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings >
    <select>*</select>
    <from>trade_trailer</from>
    <where>
        <c column='TR_JOBNOIN'		symbol='like' ignore='empty'></c>   
        <c column='TR_BLNO'		symbol='like' ignore='empty'></c>   
        <c column='TR_CONNO'		symbol='like' ignore='empty'></c>   
        <c column='TR_CARRI'		symbol='equal' ignore='empty'></c>   
        <c column='TR_CARNO'		symbol='like' ignore='empty'></c>   
        <c column='TR_ETSH'		symbol='daterange' ignore='empty'></c>   
    </where>
    <orderby>JOBNO</orderby>
</settings>");
            var service = new trade_trailerService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        // 取得编辑页面中的主表数据及上一页下一页主键 GET api/trade/send/geteditmaster 
        public virtual dynamic GetEditMaster(string id)
        {
            return new
            {
                form = masterService.GetModel(ParamQuery.Instance().Where("Jobno", id)),
                //scrollKeys = masterService.ScrollKeys("Jobno", id, ParamQuery.Instance().Where("ProjectCode", projectCode))
                scrollKeys = masterService.ScrollKeys("Jobno", id, ParamQuery.Instance().Where("Jobno", id))
            };
        }

        // 查询明细表 GET api/trade/send/getdetail
        public virtual dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceRequest()
                .SetValue("Jobno", id)
                .SetXml(string.Format(@"
<settings>
    <select>A.*, B.*</select>
    <from>
        trade_trailer A
        left join trade_scheduler B on B.jobno = A.jobno
    </from>
    <where>
        <c column='A.Jobno' symbol='equal'></c>
    </where>
    <orderby>A.Jobno</orderby>
</settings>"));

            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }


        #region 删除
        // 删除 DELETE api/trade/send
        public virtual void Delete(string id)
        {
            var result = masterService.Delete(ParamDelete.Instance().Where("Jobno", id));
            TradeHelper.ThrowHttpExceptionWhen(result <= 0, "单据删除失败[Jobno={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 审核
        // 审核 DELETE api/trade/send/audit
        [System.Web.Http.HttpPost]
        public virtual void Audit(string id, JObject data)
        {
            var status = data["status"].ToString();
            var comment = data["comment"].ToString();
            var result = new TradeService().Audit("trade_trailer", id, status, comment);
            TradeHelper.ThrowHttpExceptionWhen(result < 0, "单据审核失败[Jobno={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 保存
        // 保存 POST api/trade/send
        [System.Web.Http.HttpPost]
        public virtual void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance()
                .SetXml(@"
<settings>
    <table>trade_trailer</table>
    <where><c column='Jobno'></c></where>
</settings>");

            var listWrapper = RequestWrapper.InstanceArray(1);
            listWrapper[0].SetXml(@"
<settings>
    <table>trade_scheduler</table>
    <where>
        <c column='Jobno'></c>
        <c column='SNO'></c>
    </where>
</settings>");

            var result = masterService.Edit(data, formWrapper, listWrapper);
        }
        #endregion
    }
}