using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mms;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms.Controllers
{
    public class SendController : Controller
    {
        public ActionResult Index()
        {
            var currentProject = MmsHelper.GetCurrentProject();
            var model = new
            {
                urls = MmsHelper.GetIndexUrls("send"),
                resx = MmsHelper.GetIndexResx("发料单"),
                dataSource = new
                {
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(currentProject),
                    PriceKind = new sys_codeService().GetDynamicList(ParamQuery.Instance().Select("Code as value,Text as text").Where("CodeType", "Pricing")),
                    Purpose = new sys_codeService().GetDynamicList(ParamQuery.Instance().Select("Code as value,Text as text").Where("CodeType", "MaterialUse"))
                },
                form = new
                {
                    BillNo = "",
                    PickUnitName = "",
                    DoPerson = "",
                    WarehouseCode = "",
                    PriceKind = "",
                    SendDate = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var userName = MmsHelper.GetUserName();
            var currentProject = MmsHelper.GetCurrentProject();
            var data = new SendApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = MmsHelper.GetEditUrls("send"),
                resx = MmsHelper.GetEditResx("发料单"),
                dataSource = new
                {
                    priceKinds = codeService.GetValueTextListByType("Pricing"),
                    materialUse = codeService.GetValueTextListByType("MaterialUse"),
                    measureUnit = codeService.GetMeasureUnitListByType(),
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(currentProject)
                },
                defaultForm = new mms_send().Extend(new
                {
                    BillNo = id,
                    BillDate = DateTime.Now,
                    DoPerson = userName,
                    SendDate = DateTime.Now,
                    PriceKind = codeService.GetDefaultCode("Pricing")
                }),
                defaultRow = new
                {
                    Num = 1,
                    UnitPrice = 0,
                    Money = 0
                },
                setting = new
                {
                    postFormKeys = new string[] { "BillNo" },
                    postListFields = new string[] { "BillNo", "RowId", "MaterialCode", "Unit", "UnitPrice", "Num", "Money", "Remark", "SrcBillType", "SrcBillNo", "SrcRowId" }
                }
            };

            return View(model);
        }
    }

    public class SendApiController : MmsBaseApi<mms_send, mms_sendService, mms_sendDetail, mms_sendDetailService>
    {
        // GET api/mms/send/getdoperson
        public List<dynamic> GetDoPerson(string q)
        {
            var SendService = new mms_sendService();
            var pQuery = ParamQuery.Instance().Top(10).Select("distinct DoPerson").OrderBy("DoPerson")
                .Where(c => c.And("DoPerson", q).Symbol("StartWithPY"));
            return SendService.GetDynamicList(pQuery);
        }

        // 查询主表：GET api/mms/send
        public override dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>
        A.*, B.ProjectName, C.MaterialTypeName, D.WarehouseName,E.MerchantsName as PickUnitName
    </select>
    <from>
        mms_send A
        left join mms_project       B on B.ProjectCode      = A.ProjectCode
        left join mms_materialType  C on C.MaterialType = A.MaterialType
        left join mms_warehouse         D on D.WarehouseCode       = A.WarehouseCode
        left join mms_merchants E on E.MerchantsCode=A.PickUnit
    </from>
    <where  >
        <c column='BillNo'              symbol='equal'    ignore='empty'  ></c>
        <c column='ProjectName'         symbol='like'     ignore='empty'  ></c>
        <c column='DoPerson'            symbol='like'     ignore='empty'  ></c>
        <c column='A.WarehouseCode'     symbol='equal'    ignore='empty' values='{WarehouseCode}'      ></c>
        <c column='E.MerchantsName'     symbol='equal'    ignore='empty' values='{PickUnitName}'    ></c>
        <c column='SendDate'            symbol='daterange' ignore='empty'  ></c>
        <c column='PriceKind'           symbol='equal'    ignore='empty'  ></c>
    </where>
    <orderby>BillNo</orderby>
</settings>");

            var pQuery = query.ToParamQuery().Where("A.ProjectCode", MmsHelper.GetCurrentProject());
            return masterService.GetDynamicListWithPaging(pQuery);
        }
    }
}