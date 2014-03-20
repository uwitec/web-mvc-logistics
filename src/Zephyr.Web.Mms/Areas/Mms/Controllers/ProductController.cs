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
    public class ProductController : Controller
    {
        //
        // GET: /Mms/TestABC/

        public ActionResult Index()
        {
            var model = new
            {
                dataSource = new
                {
                    UnitItems = new sys_codeService().GetDynamicList(ParamQuery.Instance().Select("Code as value,Text as text").Where("CodeType", "MeasureUnit"))
                },
                urls = new
                {
                    query = "/api/mms/product",
                    newkey = "/api/mms/product/getnewkey",
                    edit = "/api/mms/product/edit"
                },
                resx = new
                {
                    noneSelect = "请先选择一条产品数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new
                {
                    ProductName = "",
                    Color = "",
                    Price = "",
                    Unit = "",
                    Remark ="",
                    CreateDate = ""
                },
                defaultRow = new
                {

                },
                setting = new
                {
                    postListFields = new string[] { "ID", "ProductName", "Color", "Price", "Unit", "Money", "Qty", "Remark", "CreateDate" }
                }
            };

            return View(model);
        }

    }

    public class ProductApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings>
    <select>*</select>
    <from>mms_product</from>
    <where>
        <c column='ProductName'   ignore='empty'  symbol='like'></c>
        <c column='Color'         ignore='empty'  symbol='equal' ></c>
        <c column='Price'         ignore='empty'  symbol='equal'></c>
        <c column='Unit'          ignore='empty'  symbol='equal'></c>
        <c column='Remark'        ignore='empty'  symbol='like'></c>
        <c column='CreateDate'    ignore='empty'  symbol='daterange'></c>
    </where>
    <orderby>ID</orderby>
</settings>");
            var service = new mms_productService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new mms_productService().GetNewKey("ID", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().SetXml(@"
<settings>
    <table>
        mms_product
    </table>
    <where>
        <c column='ID' symbol='equal'></c>
    </where>
</settings>");
            var service = new mms_productService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
