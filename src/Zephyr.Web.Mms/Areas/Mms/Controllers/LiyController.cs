
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mms.Models;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Mms.Controllers
{
    public class LiyController : Controller
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
                    query = "/api/Mms/Liy",
                    newkey = "/api/Mms/Liy/getnewkey",
                    edit = "/api/Mms/Liy/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    DepartmentID = "" ,
                    IsValid = "" ,
                    ApproveState = "" ,
                    Remark = "" ,
                    OutDateTime = "" 
                },
                defaultRow = new {
                   
                },
                setting = new{
                    idField = "ID",
                    postListFields = new string[] { "ID" ,"DepartmentID" ,"IsValid" ,"OutDateTime" ,"ApproveState" ,"ApprovePerson" ,"ApproveDate" ,"ApproveRemark" ,"Remark" }
                }
            };

            return View(model);
        }
    }

    public class LiyApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>test_liy</from>
    <where>
        <c column='DepartmentID'		cp='equal'    ignore='empty'></c>   
        <c column='IsValid'		        cp='equal'    ignore='empty'></c>   
        <c column='ApproveState'		cp='equal'    ignore='empty'></c>   
        <c column='Remark'		        cp='like'     ignore='empty'></c>   
        <c column='OutDateTime'		    cp='daterange' ignore='empty'></c>   
    </where>
    <orderby>ID</orderby>
</settings>");
            var service = new test_liyService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new test_liyService().GetNewKey("ID", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        test_liy
    </table>
    <where>
        <c column='ID' symbol='equal'></c>
    </where>
</settings>");
            var service = new test_liyService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
