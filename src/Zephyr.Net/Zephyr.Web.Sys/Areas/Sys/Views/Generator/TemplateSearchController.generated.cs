﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zephyr.Web.Sys.Areas.Sys.Views.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Generator/TemplateSearchController.cshtml")]
    public partial class TemplateSearchController : System.Web.Mvc.WebViewPage<dynamic>
    {
        public TemplateSearchController()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
  
    var area = Model.Area;
    var condtions = Model.Data["conditions"];
    var columns = Model.Data["columns"];
    var controller = Model.Data["controller"];
    var count1 = condtions.Count;
    var count2 = columns.Count;
    var PrimaryKey = Model.PrimaryKeys[0];

            
            #line default
            #line hidden
WriteLiteral("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Dynamic;\r\nusing " +
"System.Net.Http;\r\nusing System.Web.Http;\r\nusing System.Web.Mvc;\r\nusing Zephyr.Co" +
"re;\r\nusing Zephyr.Web.Sys.Models;\r\nusing Zephyr.Web.");

            
            #line 18 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
             Write(area);

            
            #line default
            #line hidden
WriteLiteral(".Models;\r\n\r\nnamespace Zephyr.Web.");

            
            #line 20 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                 Write(area);

            
            #line default
            #line hidden
WriteLiteral(".Controllers\r\n{\r\n    public class ");

            
            #line 22 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
             Write(controller);

            
            #line default
            #line hidden
WriteLiteral("Controller : Controller\r\n    {\r\n        public ActionResult Index()\r\n        {\r\n " +
"           var model = new\r\n            {\r\n                urls = new {\r\n       " +
"             query = \"/api/");

            
            #line 29 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                             Write(area);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 29 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                   Write(controller);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                    remove = \"/api/");

            
            #line 30 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                              Write(area);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 30 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                    Write(controller);

            
            #line default
            #line hidden
WriteLiteral("/\",\r\n                    billno = \"/api/");

            
            #line 31 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                              Write(area);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 31 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                    Write(controller);

            
            #line default
            #line hidden
WriteLiteral("/getnewbillno\",\r\n                    audit = \"/api/");

            
            #line 32 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                             Write(area);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 32 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                   Write(controller);

            
            #line default
            #line hidden
WriteLiteral("/audit/\",\r\n                    edit = \"/");

            
            #line 33 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                        Write(area);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 33 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                              Write(controller);

            
            #line default
            #line hidden
WriteLiteral(@"/edit/""
                },
                resx = new {
                    detailTitle = ""单据明细"",
                    noneSelect = ""请先选择一条单据！"",
                    deleteConfirm = ""确定要删除选中的单据吗？"",
                    deleteSuccess = ""删除成功！"",
                    auditSuccess = ""单据已审核！""
                },
                dataSource = new{
                    //dsPurpose = new sys_codeService().GetValueTextListByType(""Purpose"")
                },
                form = new{
");

            
            #line 46 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                 for (var i = 0; i < count1; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("    ");

            
            #line 48 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                 Write(condtions[i].field);

            
            #line default
            #line hidden
WriteLiteral(" = \"\" ");

            
            #line 48 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                                if (i < count1 - 1) {
            
            #line default
            #line hidden
            
            #line 48 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                                                 Write(",");

            
            #line default
            #line hidden
            
            #line 48 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                                                           }
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 49 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                },\r\n                idField=\"");

            
            #line 51 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                    Write(PrimaryKey);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n            };\r\n\r\n            return View(model);\r\n        }\r\n    }\r\n\r\n    pub" +
"lic class ");

            
            #line 58 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
             Write(controller);

            
            #line default
            #line hidden
WriteLiteral("ApiController : ApiController\r\n    {\r\n        ");

WriteLiteral("\r\n\r\n        public string GetNewBillNo()\r\n        {\r\n            return new ");

            
            #line 69 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                   Write(Model.TableName);

            
            #line default
            #line hidden
WriteLiteral("Service().GetNewKey(\"");

            
            #line 69 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                                         Write(PrimaryKey);

            
            #line default
            #line hidden
WriteLiteral("\", \"dateplus\");\r\n        }\r\n\r\n        public dynamic Get(RequestWrapper query)\r\n " +
"       {\r\n            query.SetXml(");

WriteLiteral("@\"\r\n<settings>\r\n    <select>*</select>\r\n    <from>");

            
            #line 77 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
     Write(Model.TableName);

            
            #line default
            #line hidden
WriteLiteral("</from>\r\n    <where>\r\n");

            
            #line 79 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
    
            
            #line default
            #line hidden
            
            #line 79 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
     foreach(var item in condtions)
    {

            
            #line default
            #line hidden
WriteLiteral("        <c");

WriteAttribute("column", Tuple.Create(" column=\'", 2602), Tuple.Create("\'", 2622)
            
            #line 81 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
, Tuple.Create(Tuple.Create("", 2611), Tuple.Create<System.Object, System.Int32>(item.field
            
            #line default
            #line hidden
, 2611), false)
);

            
            #line 81 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                          Write(Html.Raw("\t\t"));

            
            #line default
            #line hidden
WriteLiteral("symbol=\'");

            
            #line 81 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                                                   Write(item.cp);

            
            #line default
            #line hidden
WriteLiteral("\' ignore=\'empty\'></c>   \r\n");

            
            #line 82 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    </where>\r\n    <orderby>");

            
            #line 84 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
        Write(PrimaryKey);

            
            #line default
            #line hidden
WriteLiteral("</orderby>\r\n</settings>\");\r\n            var service = new ");

            
            #line 86 "..\..\Areas\Sys\Views\Generator\TemplateSearchController.cshtml"
                          Write(Model.TableName);

            
            #line default
            #line hidden
WriteLiteral("Service();\r\n            var pQuery = query.ToParamQuery();\r\n            var resul" +
"t = service.GetDynamicListWithPaging(pQuery);\r\n            return result;\r\n     " +
"   }\r\n    }\r\n}");

        }
    }
}
#pragma warning restore 1591
