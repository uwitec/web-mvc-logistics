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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Generator/TemplateSearchView.cshtml")]
    public partial class TemplateSearchView : System.Web.Mvc.WebViewPage<dynamic>
    {
        public TemplateSearchView()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
  
    var condtions = Model.Data["conditions"];
    var columns = Model.Data["columns"];
    var controller = Model.Data["controller"];

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("@{\r\n    ViewBag.Title = \"");

            
            #line 7 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                Write(controller);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    Layout = \"~/Views/Shared/_Layout.cshtml\";\r\n    var Cols = new Zephyr.Web." +
"Sys.Models.sys_roleMenuColumnMapService().GetCurrentUserMenuColumns();\r\n}\r\n\r\n");

WriteLiteral("@section scripts{\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 370), Tuple.Create("\"", 422)
, Tuple.Create(Tuple.Create("", 376), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/viewmodels/com.viewModel.search.js")
, 376), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var data = ");

WriteLiteral("@Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model));\r\n        var viewM" +
"odel = function(){ \r\n            com.viewModel.search.apply(this,arguments);\r\n  " +
"      }\r\n        ko.bindingViewModel(new viewModel(data));\r\n    </script>\r\n}\r\n\r\n" +
"    ");

WriteLiteral("@Html.RenderToolbar()\r\n\r\n    <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(" style=\"position:relative;\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
     for (var i = 0; i < condtions.Count; i++)
    {
        if (i % 3 == 0 && i>0)
        {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

WriteLiteral("        ");

WriteLiteral("\r\n");

            
            #line 33 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
        }

        var item = condtions[i];
        var textPlugin = new List<string>() { "text", "autocomplete", "daterange" };
        var type = item.type.ToString();
        var cls = type == "text" ? "" : ("easyui-" + type);
        var val = textPlugin.Contains(type) ? "value" : (type + "Value");

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                           Write(item.title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"grid_2 val\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"");

            
            #line 41 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                         Write(val);

            
            #line default
            #line hidden
WriteLiteral(":form.");

            
            #line 41 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                                   Write(item.field);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1425), Tuple.Create("\"", 1443)
, Tuple.Create(Tuple.Create("", 1433), Tuple.Create("z-txt", 1433), true)
            
            #line 41 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                 , Tuple.Create(Tuple.Create(" ", 1438), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 1439), false)
);

WriteLiteral(" ");

            
            #line 41 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                                                                   Write(Html.Raw(item.options.ToString() == "" ? "" : "data-options=\"" + item.options + "\""));

            
            #line default
            #line hidden
WriteLiteral("/></div>\r\n");

            
            #line 42 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 44 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
         if (condtions.Count < 4)
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

            
            #line 47 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">&nbsp;</div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"grid_2 val\"");

WriteLiteral(">&nbsp;</div>\r\n");

            
            #line 50 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
        
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n\r\n        <div");

WriteLiteral(" class=\"prefix_9\"");

WriteLiteral(" style=\"position:absolute;top:5px;height:0;\"");

WriteLiteral(">  \r\n            <a");

WriteLiteral(" id=\"a_search\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"buttonHuge button-blue\"");

WriteLiteral(" data-bind=\"click:searchClick\"");

WriteLiteral(" style=\"margin:0 15px;\"");

WriteLiteral(">查询</a> \r\n            <a");

WriteLiteral(" id=\"a_reset\"");

WriteLiteral("  href=\"#\"");

WriteLiteral(" class=\"buttonHuge button-blue\"");

WriteLiteral(" data-bind=\"click:clearClick\"");

WriteLiteral(">清空</a>\r\n        </div>\r\n    </div>\r\n \r\n    <table");

WriteLiteral(" data-bind=\"datagrid:grid\"");

WriteLiteral(">\r\n            <thead>  \r\n            <tr>  \r\n");

            
            #line 63 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
             foreach (var c in columns)
            {
                var hasFmt = c.formatter.ToString() != "";
                var hidden = c.Value<bool>("hidden");

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteAttribute("field", Tuple.Create(" field=\"", 2410), Tuple.Create("\"", 2426)
            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
, Tuple.Create(Tuple.Create("", 2418), Tuple.Create<System.Object, System.Int32>(c.field
            
            #line default
            #line hidden
, 2418), false)
);

WriteAttribute("sortable", Tuple.Create("    sortable=\"", 2427), Tuple.Create("\"", 2473)
            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
, Tuple.Create(Tuple.Create("", 2441), Tuple.Create<System.Object, System.Int32>(c.sortable.ToString().ToLower()
            
            #line default
            #line hidden
, 2441), false)
);

WriteAttribute("align", Tuple.Create(" align=\"", 2474), Tuple.Create("\"", 2490)
            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
           , Tuple.Create(Tuple.Create("", 2482), Tuple.Create<System.Object, System.Int32>(c.align
            
            #line default
            #line hidden
, 2482), false)
);

WriteAttribute("width", Tuple.Create("    width=\"", 2491), Tuple.Create("\"", 2510)
            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                               , Tuple.Create(Tuple.Create("", 2502), Tuple.Create<System.Object, System.Int32>(c.width
            
            #line default
            #line hidden
, 2502), false)
);

WriteLiteral(" ");

            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                                                                                    Write(Html.Raw(hasFmt ? "formatter=\"" + c.formatter + "\"" : ""));

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                                                                                                                                                    Write(Html.Raw(hidden ? "hidden=\"true\"" : "@Html.HideColumn(Cols,\"" + @c.field + "\")"));

            
            #line default
            #line hidden
WriteLiteral(" >");

            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
                                                                                                                                                                                                                                                                           Write(c.title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 68 "..\..\Areas\Sys\Views\Generator\TemplateSearchView.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </tr>                            \r\n        </thead>      \r\n    </tabl" +
"e>\r\n ");

        }
    }
}
#pragma warning restore 1591
