using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Zephyr.Web.Mvc;
using Zephyr.Web.Mms;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms.Controllers
{
    public class RefundController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = MmsHelper.GetIndexUrls("refund"),
                resx = MmsHelper.GetIndexResx("退库单"),
                dataSource = new
                {
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(MmsHelper.GetCurrentProject())
                },
                form = new
                {
                    BillNo = "",
                    RefundUnitName = "",
                    RefundPerson = "",
                    WarehouseCode = "",
                    MaterialType = "",
                    RefundDate = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id = "")
        {
            var userName = MmsHelper.GetUserName();
            var currentProject = MmsHelper.GetCurrentProject();
            var data = new RefundApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = MmsHelper.GetEditUrls("refund"),
                resx = MmsHelper.GetEditResx("退库单"),
                dataSource = new
                {
                    measureUnit = codeService.GetMeasureUnitListByType(),
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(currentProject)
                },
                defaultForm = new mms_refund().Extend(new
                {
                    BillNo = id,
                    BillDate = DateTime.Now,
                    DoPerson = userName,
                    RefundDate = DateTime.Now
                }),
                defaultRow = new
                {
                    Num = 1,
                    UnitPrice = 0,
                    TotalMoney = 0
                },
                setting = new
                {
                    postFormKeys = new string[] { "BillNo" },
                    postListFields = new string[] { "BillNo", "RowId", "MaterialCode", "Unit", "UnitPrice", "Num", "Money", "Remark","SrcBillType","SrcBillNo","SrcRowId" }
                }
            };

            return View(model);
        }
    }

    public class RefundApiController : MmsBaseApi<mms_refund, mms_refundService, mms_refundDetail, mms_refundDetailService>
    {
        // 地址：GET api/mms/refund/getdoperson
        public List<dynamic> GetRefundPerson(string q)
        {
            var SendService = new mms_refundService();
            var pQuery = ParamQuery.Instance().Select("top 10 RefundPerson").Where(c => c.And("RefundPerson", q).Symbol("StartWithPY"));//.AndWhere("RefundPerson", q, Cp.StartWithPY);
            return SendService.GetDynamicList(pQuery);
        }

        // 地址：GET api/mms/refund
        public override dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>
        A.*, B.ProjectName, C.MaterialTypeName, D.WarehouseName,E.MerchantsName as RefundUnitName
    </select>
    <from>
        mms_refund A
        left join mms_project       B on B.ProjectCode      = A.ProjectCode
        left join mms_materialType  C on C.MaterialType = A.MaterialType
        left join mms_warehouse     D on D.WarehouseCode       = A.WarehouseCode
        left join mms_merchants     E on E.MerchantsCode    = A.RefundUnit
    </from>
    <where>
        <c column='BillNo'              symbol='equal'    ignore='empty'  ></c>
        <c column='ProjectName'         symbol='like'     ignore='empty'  ></c>
        <c column='E.MerchantsName'     symbol='like'     ignore='empty' values='{RefundUnitName}'></c>
        <c column='A.WarehouseCode'     symbol='equal'    ignore='empty' values='{WarehouseCode}'></c>
        <c column='A.MaterialType'      symbol='equal'    ignore='empty'  ></c>
        <c column='RefundDate'          symbol='daterange' ignore='empty'  ></c>
    </where>
    <orderby>BillNo</orderby>
</settings>");

            var pQuery = query.ToParamQuery().Where("A.ProjectCode", MmsHelper.GetCurrentProject());
            return masterService.GetDynamicListWithPaging(pQuery);
        }

        public override dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceRequest()
                .SetValue("BillNo", id)
                .SetXml(@"
<settings>
    <select>
        A.*, B.MaterialName,B.Model,B.Material,C.UnitPrice as SrcUnitPrice,C.Num as SrcNum
    </select>
    <from>
        mms_refundDetail A
        left join mms_material B on B.MaterialCode = A.MaterialCode
        left join mms_sendDetail C on C.BillNo =  A.SrcBillNo and C.RowId = A.SrcRowId
    </from>
    <where>
        <c column='A.BillNo' symbol='equal'></c>
    </where>
    <orderby>MaterialCode</orderby>
</settings>");

            var pQuery = query.ToParamQuery();
            var result = masterService.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}