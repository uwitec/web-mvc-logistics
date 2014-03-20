using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Mms;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms.Controllers
{
    public class TestABCController : Controller
    {
        //
        // GET: /Mms/TestABC/

        public ActionResult Index()
        {
           var model = new
            {
                dataSource = new{
                    TypeItems = new sys_codeService().GetDynamicList(ParamQuery.Instance().Select("Code as value,Text as text").Where("CodeType", "Pricing"))
                },
                urls = new{
                    query = "/api/mms/testabc",
                    newkey = "/api/mms/testabc/getnewkey",
                    edit = "/api/mms/testabc/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条货物数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    Year = "",
                    ProjectName = "",
                    DeclaringUnits = "",
                    ProjectType = "",
                    StartDate="",
                    EndDate =""
                },
                defaultRow = new {
                    
                },
                setting = new{
                    postListFields = new string[] { "ID", "Year", "ProjectName", "DeclaringUnits", "ProjectType", "StartDate", "EndDate","TotalMoney","Remark" }
                }
            };

           return View(model);
        }

    }

    public class TestABCApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>mms_test</from>
    <where>
        <c column='ID'                ignore='empty'    symbol='equal'></c>
        <c column='ProjectName'       ignore='empty'    symbol='like' ></c>
        <c column='DeclaringUnits'    ignore='empty'    symbol='like'></c>
        <c column='ProjectType'       ignore='empty'    symbol='equal'></c>
        <c column='StartDate'         ignore='empty'    symbol='dtgreaterequal'></c>
        <c column='EndDate'           ignore='empty'    symbol='dtlessequal'></c>
    </where>
    <orderby>ID</orderby>
</settings>");
            var service = new mms_testService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new mms_testService().GetNewKey("ID", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        mms_test
    </table>
    <where>
        <c column='ID' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_testService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
