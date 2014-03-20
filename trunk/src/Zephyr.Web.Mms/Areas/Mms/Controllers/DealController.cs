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
    public class DealController : Controller
    {
        public ActionResult Index()
        {
            var codeService = new sys_codeService();
            var model = new
            {
                urls = MmsHelper.GetIndexUrls("deal"),
                resx = MmsHelper.GetIndexResx("处置单"),
                dataSource = new
                {
                    disposalTypes = codeService.GetValueTextListByType("DisposalType"),
                    disposalWays = codeService.GetValueTextListByType("DisposalWay")
                },
                form = new
                {
                    BillNo = "",
                    ProjectName = "",
                    DoPerson = "",
                    DealType = "",
                    DealKind = "",
                    ApplyDate = ""
                }
            };

            return View(model);
        }

        public ActionResult Edit(string id = "")
        {
            var userName = MmsHelper.GetUserName();
            var currentProject = MmsHelper.GetCurrentProject();
            var data = new DealApiController().GetEditMaster(id);
            var codeService = new sys_codeService();

            var model = new
            {
                form = data.form,
                scrollKeys = data.scrollKeys,
                urls = MmsHelper.GetEditUrls("deal"),
                resx = MmsHelper.GetEditResx("处置单"),
                dataSource = new
                {
                    measureUnit = codeService.GetMeasureUnitListByType(),
                    disposalTypes = codeService.GetValueTextListByType("DisposalType"),
                    disposalWays = codeService.GetValueTextListByType("DisposalWay")
                },
                defaultForm = new mms_deal().Extend(new
                {
                    BillNo = id,
                    BillDate = DateTime.Now,
                    DoPerson = userName,
                    ApplyDate = DateTime.Now,
                    DealType = codeService.GetDefaultCode("DisposalType"),
                    DealKind = codeService.GetDefaultCode("DisposalWay"),
                }),
                defaultRow = new
                {
                    UnitPrice = 0,
                    Num = 1,
                    Money = 0,
                    DealDate=DateTime.Now
                },
                setting = new
                {
                    postFormKeys = new string[] { "BillNo" },
                    postListFields = new string[] { "BillNo", "RowId", "MaterialName", "Model", "Unit", "DealDate", "ExpendCompany", "UnitPrice", "Num", "Money", "Remark" }
                }
            };

            return View(model);
        }
    }

    public class DealApiController : MmsBaseApi<mms_deal, mms_dealService, mms_dealDetail, mms_dealDetailService>
    {
        public List<dynamic> GetDoPerson(string q)
        {
            var pQuery = ParamQuery.Instance().Select("top 10 DoPerson").Where(c => c.And("DoPerson", q).Symbol("StartWithPY"));
            return masterService.GetDynamicList(pQuery);
        }
         
        public override dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>
        A.*, B.ProjectName
    </select>
    <from>
        mms_deal A
        left join mms_project       B on B.ProjectCode      = A.ProjectCode
    </from>
    <where>
        <c column='BillNo'              symbol='equal'     ignore='empty' ></c>
        <c column='ProjectName'         symbol='like'      ignore='empty' ></c>
        <c column='DoPerson'            symbol='like'      ignore='empty' ></c>
        <c column='DealType'            symbol='equal'     ignore='empty' ></c>
        <c column='DealKind'            symbol='equal'     ignore='empty' ></c>
        <c column='ApplyDate'           symbol='daterange' ignore='empty' ></c>
    </where>
    <orderby>BillNo</orderby>
</settings>");

            var pQuery = query.ToParamQuery().Where("A.ProjectCode", MmsHelper.GetCurrentProject());
            return masterService.GetDynamicListWithPaging(pQuery);
        }

        // 地址：GET api/mms/deal/getdetail
        public override dynamic GetDetail(string id)
        {
            var query = RequestWrapper
                .InstanceRequest()
                .SetValue("BillNo", id)
                .SetXml(@"
<settings>
    <select>
        A.*,B.MerchantsName as ExpendCompanyName
    </select>
    <from>
        mms_dealDetail A
        left join mms_merchants B on B.MerchantsCode = A.ExpendCompany
    </from>
    <where>
        <c column='BillNo' symbol='equal'></c>
    </where>
    <orderby>RowId</orderby>
</settings>");

            var pQuery = query.ToParamQuery();
            var result = detailService.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}