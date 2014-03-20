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
    public class RentOffController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = MmsHelper.GetIndexUrls("rentoff"),
                resx = MmsHelper.GetIndexResx("停租单"),
                dataSource = new
                {
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(MmsHelper.GetCurrentProject())
                },
                form = new
                {
                    BillNo = "",
                    ProjectName = "",
                    DoPerson = "",
                    ContractCode = "",
                    BeginDate = "",
                    EndDate = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var userName = MmsHelper.GetUserName();
            var currentProject = MmsHelper.GetCurrentProject();
            var data = new RentOffApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = MmsHelper.GetEditUrls("rentOff"),
                resx = MmsHelper.GetEditResx("停租单"),
                dataSource = new
                {
                    measureUnit = codeService.GetMeasureUnitListByType(),
                    warehouseItems = new mms_warehouseService().GetWarehouseItems(currentProject)
                },
                defaultForm = new mms_rentOff().Extend(new
                {
                    BillNo = id,
                    BillDate = DateTime.Now,
                    DoPerson = userName,
                    BeginDate = DateTime.Now
                }),
                defaultRow = new
                {
                    UnitPrice = 0,
                    Num = 1,
                    Day = 1,
                    PrePay = 0
                },
                setting = new
                {
                    postFormKeys = new string[] { "BillNo" },
                    postListFields = new string[] { "BillNo", "RowId", "MaterialCode", "Unit", "UnitPrice", "Num", "Day", "Money", "Remark" }
                }
            };

            return View(model);
        }
    }

    public class RentOffApiController : MmsBaseApi<mms_rentOff, mms_rentOffService, mms_rentOffDetail, mms_rentOffDetailService>
    {
        // 地址：GET api/mms/send/getdoperson
        public List<dynamic> GetDoPerson(string q)
        {
            var SendService = new mms_rentOffService();
            var pQuery = ParamQuery.Instance().Select("top 10 DoPerson").Where(c => c.And("DoPerson", q).Symbol("StartWithPY"));//.AndWhere("DoPerson", q, Cp.StartWithPY);
            return SendService.GetDynamicList(pQuery);
        }
 
        public override dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings >
    <select>
        A.*, B.ProjectName, C.MerchantsName
    </select>
    <from>
        mms_rentOff A
        left join mms_project       B on B.ProjectCode      = A.ProjectCode
        left join mms_merchants     C on C.MerchantsCode    = A.SupplierCode
    </from>
    <where>
        <c column='BillNo'             symbol='equal'      ignore='empty'></c>
        <c column='ProjectName'        symbol='like'       ignore='empty'></c>
        <c column='DoPerson'           symbol='like'       ignore='empty'></c>
        <c column='ContractCode'       symbol='equal'      ignore='empty'></c>
        <c column='BeginDate'          symbol='daterange'  ignore='empty'></c>
        <c column='EndDate'            symbol='daterange'  ignore='empty'></c>
    </where>
    <orderby>BillNo</orderby>
</settings>");

            return base.Get(query);
        }
    }
}