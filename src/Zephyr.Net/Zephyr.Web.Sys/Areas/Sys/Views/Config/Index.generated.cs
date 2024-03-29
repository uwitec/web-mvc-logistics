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

namespace Zephyr.Web.Sys.Areas.Sys.Views.Config
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Config/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Config\Index.cshtml"
  
    ViewBag.Title = "系统设置";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("head", () => {

WriteLiteral("\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(@">
        input { width: 124px; }
        h1 {font-size: 18px;font-family: 'Microsoft YaHei';padding: 0px;padding-left: 20px;color: #A2A2A2;margin-bottom: 5px;}
        ul { list-style: none; }
        li div {width: 140px;float: left;text-align: right;padding-right: 10px;}
        .c {margin: 5px;border-top: 2px solid #1382CE;margin-bottom: 15px;padding-top: 10px;}
    </style>
");

});

WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Areas\Sys\Views\Config\Index.cshtml"
Write(Scripts.Render("~/Resource/Sys/Config.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var data = ");

            
            #line 20 "..\..\Areas\Sys\Views\Config\Index.cshtml"
              Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        ko.bindingViewModel(new viewModel(data));\r\n    </script>\r\n");

});

WriteLiteral("    <div");

WriteLiteral(" style=\"margin:10px;\"");

WriteLiteral(">\r\n        <h1>皮肤设置</h1>\r\n        <div");

WriteLiteral(" class=\"c\"");

WriteLiteral(">\r\n            <ul>\r\n                <li>\r\n                    <div>皮肤：</div>\r\n  " +
"                  <input");

WriteLiteral(" data-bind=\"comboboxValue:form.theme\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"txt_theme\"");

WriteLiteral("\r\n                           data-options=\"data: data.dataSource.themes, editable" +
": false\"");

WriteLiteral(" \r\n                           class=\"easyui-combobox\"");

WriteLiteral(" />\r\n                </li>\r\n            </ul>\r\n        </div>\r\n\r\n        <h1>菜单设置" +
"</h1>\r\n        <div");

WriteLiteral(" class=\"c\"");

WriteLiteral(">\r\n            <ul>\r\n                <li>\r\n                    <div>表现方式：</div>\r\n" +
"                    <input");

WriteLiteral(" data-bind=\"comboboxValue:form.navigation\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"txt_nav_showtype\"");

WriteLiteral(" name=\"navshowtype\"");

WriteLiteral(" data-options=\"data: data.dataSource.navigations, editable: false\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral("/> \r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"未实现...\"");

WriteLiteral(" style=\"color: blue;\"");

WriteLiteral(">查看效果图</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <h1" +
">数据表格设置</h1>\r\n        <div");

WriteLiteral(" class=\"c\"");

WriteLiteral(">\r\n            <ul>\r\n                <li>\r\n                    <div>每页记录数：</div>\r" +
"\n                    <input");

WriteLiteral(" data-bind=\"numberspinnerValue:form.gridrows\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"txt_grid_rows\"");

WriteLiteral(" data-options=\"min:10,max:1000,increment:10\"");

WriteLiteral(" class=\"easyui-numberspinner\"");

WriteLiteral(" />\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n    " +
"<div");

WriteLiteral(" style=\"margin:140px;width:160px; margin-top:40px; font-family:\'Microsoft YaHei\'\"" +
"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"btnok\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"buttonHuge button-blue\"");

WriteLiteral(" data-bind=\"click:save\"");

WriteLiteral(">保存设置</a>\r\n    </div>\r\n");

        }
    }
}
#pragma warning restore 1591
