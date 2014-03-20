using System;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mms;
using Zephyr.Web.Sys.Models;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Web.Http;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mms.Controllers
{
    public class ReceiveController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = MmsHelper.GetIndexUrls("receive"),
                resx = MmsHelper.GetIndexResx("收料单"),
                dataSource = new
                {
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(MmsHelper.GetCurrentProject()),
                    supplyType = new sys_codeService().GetValueTextListByType("SupplyType")
                },
                form = new
                {
                    BillNo = "",
                    //ProjectName = "",
                    SupplierName = "",
                    SupplyType = "",
                    WarehouseCode = "",
                    ContractCode="",
                    //MaterialType = "",
                    ReceiveDate = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var userName = MmsHelper.GetUserName();
            var currentProject = MmsHelper.GetCurrentProject();
            var data = new ReceiveApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = MmsHelper.GetEditUrls("receive"),
                resx = MmsHelper.GetEditResx("收料单"),
                dataSource = new
                {
                    measureUnit = codeService.GetMeasureUnitListByType(),
                    supplyType = codeService.GetValueTextListByType("SupplyType"),
                    payKinds = codeService.GetValueTextListByType("PayType"),
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(currentProject)
                },
                defaultForm = new mms_receive().Extend(new
                {
                    BillNo = id,
                    BillDate = DateTime.Now,
                    DoPerson = userName,
                    ReceiveDate = DateTime.Now,
                    SupplyType = codeService.GetDefaultCode("SupplyType"),
                    PayKind = codeService.GetDefaultCode("PayType"),
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
                    postFormKeys = new string[] { "BillNo" },
                    postListFields = new string[] { "BillNo", "RowId", "MaterialCode", "Unit", "CheckNum", "Num", "UnitPrice", "PrePay", "Money", "Remark" }
                }
            };
            return View(model);
        }
    }

    public class ReceiveApiController: ApiController// : MmsBaseApi<mms_receive, mms_receiveService, mms_receiveDetail, mms_receiveDetailService>
    {
        mms_receiveService masterService = new mms_receiveService();
        mms_receiveDetailService detailService = new mms_receiveDetailService();
        string projectCode = MmsHelper.GetCurrentProject(); 

        #region 自动完成
        // GET api/mms/send/getbillno
        public virtual List<dynamic> GetBillNo(string q)
        {
            var pQuery = ParamQuery.Instance().Select("top 10 BillNo").Where(c => c.And("BillNo", q).Symbol("StartWithPY"));
            return masterService.GetDynamicList(pQuery);
        }
        #endregion

        #region 采播
        // 取得新的主表Bill GET api/mms/send/getnewbillno
        public virtual string GetNewBillNo()
        {
            return masterService.GetNewKey("BillNo", "dateplus");
        }

        // 取得新的明细表RowId GET api/mms/send/getnewrowid
        public virtual string GetNewRowId(int id, string BillNo)
        {
            return detailService.GetNewKey("RowId", "maxplus", id, ParamQuery.Instance().Where("BillNo", BillNo));
        }
        #endregion

        #region 查询
        // 查询主表数据列表 GET api/mms/send 
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>
        A.*, B.ProjectName, C.MaterialTypeName, D.WarehouseName as WarehouseName, E.MerchantsName AS SupplierName
    </select>
    <from>
        mms_receive A
        left join mms_project       B on B.ProjectCode      = A.ProjectCode
        left join mms_materialType  C on C.MaterialType     = A.MaterialType
        left join mms_warehouse     D on D.WarehouseCode    = A.WarehouseCode
        left join mms_merchants     E on E.MerchantsCode    = A.SupplierCode
    </from>
    <where>
        <c column='BillNo'                symbol='equal'     ignore='empty'      ></c>
        <c column='DoPerson'              symbol='like'      ignore='empty'      ></c>
        <c column='E.MerchantsName'       symbol='like'      ignore='empty' values='{SupplierName}'></c>
        <c column='A.WarehouseCode'       symbol='equal'     ignore='empty'     ></c>
        <c column='A.MaterialType'        symbol='equal'     ignore='empty'     ></c>
        <c column='ReceiveDate'           symbol='daterange' ignore='empty'     ></c>
        <c column='ContractCode'          symbol='like'      ignore='empty'     ></c>
    </where>
    <orderby>BillNo</orderby>
</settings>");

            var pQuery = query.ToParamQuery().Where("A.ProjectCode", MmsHelper.GetCurrentProject());

            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
            //return base.Get(query);
        }

        // 取得编辑页面中的主表数据及上一页下一页主键 GET api/mms/send/geteditmaster 
        public virtual dynamic GetEditMaster(string id)
        {
            return new
            {
                form = masterService.GetModel(ParamQuery.Instance().Where("BillNo", id)),
                scrollKeys = masterService.ScrollKeys("BillNo", id, ParamQuery.Instance().Where("ProjectCode", projectCode))
            };
        }

        // 查询明细表 GET api/mms/send/getdetail
        public virtual dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceRequest()
                .SetValue("BillNo", id)
                .SetXml(string.Format(@"
<settings>
    <select>A.*, B.MaterialName,B.Model,B.Material</select>
    <from>
        {0} A
        left join mms_material B on B.MaterialCode = A.MaterialCode
    </from>
    <where>
        <c column='BillNo' symbol='equal'></c>
    </where>
    <orderby>MaterialCode</orderby>
</settings>", "mms_receiveDetail"));

            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }
        #endregion

        #region 删除
        // 删除 DELETE api/mms/send
        public virtual void Delete(string id)
        {
            var result = masterService.Delete(ParamDelete.Instance().Where("BillNo", id));
            MmsHelper.ThrowHttpExceptionWhen(result <= 0, "单据删除失败[BillNo={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 审核
        // 审核 DELETE api/mms/send/audit
        [System.Web.Http.HttpPost]
        public virtual void Audit(string id, JObject data)
        {
            var status = data["status"].ToString();
            var comment = data["comment"].ToString();
            var result = new MmsService().Audit("mms_receive", id, status, comment);
            MvcHelper.ThrowHttpExceptionWhen(result < 0, "单据审核失败[BillNo={0}]，请重试或联系管理员！", id);
        }
        #endregion

        #region 保存
        // 保存 POST api/mms/send
        [System.Web.Http.HttpPost]
        public virtual void Edit(dynamic data)
        {
            var formWrapper = RequestWrapper.Instance()
                .SetXml(@"
<settings>
    <table>mms_receive</table>
    <where><c column='BillNo'></c></where>
</settings>");

            var listWrapper = RequestWrapper.InstanceArray(1);
            listWrapper[0].SetXml(@"
<settings>
    <table>mms_receiveDetail</table>
    <where>
        <c column='BillNo'></c>
        <c column='RowId'></c>
    </where>
</settings>");

            var result = masterService.Edit(data, formWrapper, listWrapper);
        }
        #endregion
    }
}