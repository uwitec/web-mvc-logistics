using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Trade.Models;

namespace Zephyr.Web.Trade.Controllers
{
    public class AreaController : Controller
    {
        public ActionResult Index()
        {
            var code = new sys_codeService();
            var model = new
            {
                dataSource = new{
                    dsPricing = code.GetValueTextListByType("Pricing")
                },
                urls = new{
                    query = "/api/Trade/Area",
                    newkey = "/api/Trade/Area/getnewkey",
                    edit = "/api/Trade/Area/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    areacd = "" ,
                    parentcd = "" ,
                    areahelpcd = "" ,
                    areaname = "" 
                },
                defaultRow = new {
                   
                },
                setting = new{
                    idField = "keyid",
                    postListFields = new string[] { "keyid" ,"areacd" ,"parentcd" ,"areahelpcd" ,"areaname" ,"attreg" ,"isportid" ,"isdockid" ,"isairportid" ,"zoneid" ,"stateid" ,"CreatePerson" ,"createdate" ,"UpdatePerson" ,"UpdateDate" }
                }
            };

            return View(model);
        }
    }

    public class AreaApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings >
    <select>*</select>
    <from>base_area</from>
    <where>
        <c column='areacd'		symbol='equal' ignore='empty'></c>   
        <c column='parentcd'		symbol='equal' ignore='empty'></c>   
        <c column='areahelpcd'		symbol='equal' ignore='empty'></c>   
        <c column='areaname'		symbol='equal' ignore='empty'></c>   
    </where>
    <orderby>keyid</orderby>
</settings>");
            var service = new base_areaService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new base_areaService().GetNewKey("keyid", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>base_area</table>
    <where>
        <c column='keyid' symbol='equal'></c>
    </where>
</settings>");
            var service = new base_areaService();
            var result = service.Edit(data,null, tabsWrapper);
        }
    }
}