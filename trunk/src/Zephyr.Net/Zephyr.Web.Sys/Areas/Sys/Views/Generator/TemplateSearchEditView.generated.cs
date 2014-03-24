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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Generator/TemplateSearchEditView.cshtml")]
    public partial class TemplateSearchEditView : System.Web.Mvc.WebViewPage<dynamic>
    {
        public TemplateSearchEditView()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
  
    var condtions = Model.Data["conditions"];
    var columns = Model.Data["columns"];
    var controller = Model.Data["controller"];

    var usingPlugins = new List<string>();
    var plugins = new List<string>() {"numberbox","datebox","validatebox"};
    foreach (var item in columns)
    {
        var editor = item.Value<string>("editor");
        foreach(var plugin in plugins)
        {
            var quotePlugin = string.Format("'{0}'", plugin);
            if (editor.IndexOf(plugin) > -1 && !usingPlugins.Contains(quotePlugin))
            {
                usingPlugins.Add(quotePlugin);
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("@{\r\n    ViewBag.Title = \"");

            
            #line 22 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                Write(controller);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    Layout = \"~/Views/Shared/_Layout.cshtml\";\r\n}\r\n\r\n");

WriteLiteral("@section scripts{\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 776), Tuple.Create("\"", 832)
, Tuple.Create(Tuple.Create("", 782), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/viewmodels/com.viewModel.searchEdit.js")
, 782), false)
);

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
     if (usingPlugins.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("using([");

            
            #line 31 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
        Write(Html.Raw(string.Join(",", usingPlugins.ToArray())));

            
            #line default
            #line hidden
WriteLiteral("]);\r\n");

            
            #line 32 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    var data = ");

WriteLiteral("@Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model));\r\n    ko.bindingVie" +
"wModel(new com.viewModel.searchEdit(data));\r\n</script>\r\n}\r\n<div");

WriteLiteral(" class=\"z-toolbar\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral("  icon=\"icon-arrow_refresh\"");

WriteLiteral("   title=\"刷新\"");

WriteLiteral(" data-bind=\"click:refreshClick\"");

WriteLiteral(">刷新</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral("  icon=\"icon-add\"");

WriteLiteral("             title=\"新增\"");

WriteLiteral(" data-bind=\"click:addClick\"");

WriteLiteral("    >新增</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral("  icon=\"icon-edit\"");

WriteLiteral("            title=\"编辑\"");

WriteLiteral(" data-bind=\"click:editClick\"");

WriteLiteral("   >编辑</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral("  icon=\"icon-cross\"");

WriteLiteral("           title=\"删除\"");

WriteLiteral(" data-bind=\"click:deleteClick\"");

WriteLiteral(" >删除</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral("  icon=\"icon-save\"");

WriteLiteral("            title=\"保存\"");

WriteLiteral(" data-bind=\"click:saveClick\"");

WriteLiteral("   >保存</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-splitbutton\"");

WriteLiteral(" data-options=\"menu:\'#dropdown\',iconCls:\'icon-download\'\"");

WriteLiteral("                >导出</a>\r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"dropdown\"");

WriteLiteral(" style=\"width:100px; display:none;\"");

WriteLiteral(">  \r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-ext-xls\'\"");

WriteLiteral("      suffix=\"xls\"");

WriteLiteral("    data-bind=\"click:downloadClick\"");

WriteLiteral(">Excel2003   </div>  \r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-page_excel\'\"");

WriteLiteral("   suffix=\"xlsx\"");

WriteLiteral("   data-bind=\"click:downloadClick\"");

WriteLiteral(">Excel2007   </div>  \r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-ext-doc\'\"");

WriteLiteral("      suffix=\"doc\"");

WriteLiteral("    data-bind=\"click:downloadClick\"");

WriteLiteral(">Word2003    </div>  \r\n</div> \r\n\r\n<div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(" style=\"position:relative;\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
 for (var i = 0; i < condtions.Count; i++)
{
    if (i % 3 == 0 && i>0)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

WriteLiteral("    ");

WriteLiteral("\r\n");

            
            #line 60 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
    }

    var item = condtions[i];
    var textPlugin = new List<string>() { "text", "autocomplete", "daterange" };
    var type = item.type.ToString();
    var cls = type == "text" ? "" : ("easyui-" + type);
    var val = textPlugin.Contains(type) ? "value" : (type + "Value");

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">");

            
            #line 67 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                       Write(item.title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"grid_2 val\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"");

            
            #line 68 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                     Write(val);

            
            #line default
            #line hidden
WriteLiteral(":form.");

            
            #line 68 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                               Write(item.field);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 3025), Tuple.Create("\"", 3043)
, Tuple.Create(Tuple.Create("", 3033), Tuple.Create("z-txt", 3033), true)
            
            #line 68 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
             , Tuple.Create(Tuple.Create(" ", 3038), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 3039), false)
);

WriteLiteral(" ");

            
            #line 68 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                               Write(Html.Raw(item.options.ToString() == "" ? "" : "data-options=\"" + item.options + "\""));

            
            #line default
            #line hidden
WriteLiteral("/></div>\r\n");

            
            #line 69 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 71 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
     if (condtions.Count < 4)
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

            
            #line 74 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">&nbsp;</div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"grid_2 val\"");

WriteLiteral(">&nbsp;</div>\r\n");

            
            #line 77 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
        
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"prefix_9\"");

WriteLiteral(" style=\"position:absolute;top:5px;height:0;\"");

WriteLiteral(">  \r\n        <a");

WriteLiteral(" id=\"a_search\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"buttonHuge button-blue\"");

WriteLiteral(" data-bind=\"click:searchClick\"");

WriteLiteral(" style=\"margin:0 15px;\"");

WriteLiteral(">查询</a> \r\n        <a");

WriteLiteral(" id=\"a_reset\"");

WriteLiteral("  href=\"#\"");

WriteLiteral(" class=\"buttonHuge button-blue\"");

WriteLiteral(" data-bind=\"click:clearClick\"");

WriteLiteral(">清空</a>\r\n    </div>\r\n</div>\r\n\r\n<table");

WriteLiteral(" data-bind=\"datagrid:grid\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n    <thead>  \r\n        <tr>  \r\n");

            
            #line 90 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
        
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
         foreach (var c in columns)
        {
            var hasFmt = c.formatter.ToString() != "";
            var hasEdt = c.editor.ToString() != "";
            var hidden = c.Value<bool>("hidden");

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteAttribute("field", Tuple.Create(" field=\"", 3995), Tuple.Create("\"", 4011)
            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
, Tuple.Create(Tuple.Create("", 4003), Tuple.Create<System.Object, System.Int32>(c.field
            
            #line default
            #line hidden
, 4003), false)
);

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                           Write(Html.Raw("\t"));

            
            #line default
            #line hidden
            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                          Write(Html.Raw(hidden ? "hidden=\"true\"" : ""));

            
            #line default
            #line hidden
            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                    Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("sortable=\"");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                             Write(c.sortable.ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\"");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                              Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("align=\"");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                    Write(c.align);

            
            #line default
            #line hidden
WriteLiteral("\"");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                             Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("width=\"");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                                                   Write(c.width);

            
            #line default
            #line hidden
WriteLiteral("\" ");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                                                             Write(Html.Raw(hasEdt ? "editor=\"" + @c.editor + "\"" : ""));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                                                                                                                     Write(Html.Raw(hasFmt ? "formatter=\"" + c.formatter + "\"" : ""));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 95 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
                                                                                                                                                                                                                                                                                                                                  Write(c.title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 96 "..\..\Areas\Sys\Views\Generator\TemplateSearchEditView.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </tr>                            \r\n    </thead>      \r\n</table> ");

        }
    }
}
#pragma warning restore 1591