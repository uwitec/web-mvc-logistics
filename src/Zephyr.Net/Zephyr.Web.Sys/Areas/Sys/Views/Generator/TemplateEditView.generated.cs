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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Generator/TemplateEditView.cshtml")]
    public partial class TemplateEditView : System.Web.Mvc.WebViewPage<dynamic>
    {
        public TemplateEditView()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
  
    var condtions = Model.Data["conditions"];
    var columns = Model.Data["columns"];
    var controller = Model.Data["controller"];
    var tabs = Model.Data["tabs"];
    var count = condtions.Count;
    var gridHehgit = 71 + (count > 0 ? 2 : 0) + Math.Ceiling(count / 3.0) * 26;
    var tabHeight = gridHehgit + 4;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("@{\r\n    ViewBag.Title = \"");

            
            #line 11 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                Write(controller);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    Layout = \"~/Views/Shared/_Layout.cshtml\";\r\n}\r\n\r\n");

WriteLiteral("@section scripts{\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 452), Tuple.Create("\"", 502)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/viewmodels/com.viewModel.edit.js")
, 458), false)
);

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var viewModel = function(data){ \r\n        var self = this;\r\n        com.vi" +
"ewModel.edit.apply(self,arguments);\r\n");

            
            #line 21 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
         for (var i = 0; i < tabs.Count; i++)
        {
            if (tabs[i].type.ToString() == "grid")
            {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("    this.grid");

            
            #line 25 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                   Write(i);

            
            #line default
            #line hidden
WriteLiteral(".size={w:8,h:");

            
            #line 25 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                   Write(gridHehgit);

            
            #line default
            #line hidden
WriteLiteral("};\r\n");

            
            #line 26 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    } \r\n    var data = ");

WriteLiteral("@Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model));\r\n    ko.bindingVie" +
"wModel(new viewModel(data));\r\n</script>\r\n}\r\n\r\n<div");

WriteLiteral(" class=\"z-toolbar\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"a_save\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-save\"");

WriteLiteral(" data-bind=\"click:readonly()?null:saveClick,linkbuttonDisable:readonly\"");

WriteLiteral(" title=\"保存\"");

WriteLiteral(">保存</a>\r\n    <a");

WriteLiteral(" id=\"a_undo\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-undo\"");

WriteLiteral(" data-bind=\"click:readonly()?null:rejectClick,linkbuttonDisable:readonly\"");

WriteLiteral(" title=\"撤消\"");

WriteLiteral(">撤消</a>\r\n    <a");

WriteLiteral(" id=\"a_audit\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-user-accept\"");

WriteLiteral(" data-bind=\"click:auditClick,easyuiLinkbutton:approveButton\"");

WriteLiteral(" title=\"审核\"");

WriteLiteral(">审核</a>\r\n    <a");

WriteLiteral(" id=\"a_printer\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-printer\"");

WriteLiteral(" title=\"打印\"");

WriteLiteral(" data-bind=\"click:printClick\"");

WriteLiteral(">打印</a>\r\n    <div");

WriteLiteral(" class=\"datagrid-btn-separator\"");

WriteLiteral("></div>\r\n    <a");

WriteLiteral(" id=\"a_other\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"easyui-splitbutton\"");

WriteLiteral(" data-options=\"menu:\'#divother\',iconCls:\'icon-application_go\'\"");

WriteLiteral(" title=\"其他\"");

WriteLiteral(">其他</a>\r\n    <div");

WriteLiteral(" class=\"datagrid-btn-separator\"");

WriteLiteral("></div>\r\n    <a");

WriteLiteral(" id=\"a_first\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-resultset_first\"");

WriteLiteral(" data-bind=\"click:firstClick,linkbuttonEnable:pageData.scrollKeys.firstEnable\"");

WriteLiteral(" title=\"第一条\"");

WriteLiteral("></a> \r\n    <a");

WriteLiteral(" id=\"a_previous\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-resultset_previous\"");

WriteLiteral(" data-bind=\"click:previousClick,linkbuttonEnable:pageData.scrollKeys.previousEnab" +
"le\"");

WriteLiteral(" title=\"上一条\"");

WriteLiteral("></a> \r\n    <a");

WriteLiteral(" id=\"a_next\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-resultset_next\"");

WriteLiteral(" data-bind=\"click:nextClick,linkbuttonEnable:pageData.scrollKeys.nextEnable\"");

WriteLiteral(" title=\"下一条\"");

WriteLiteral("></a> \r\n    <a");

WriteLiteral(" id=\"a_last\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-resultset_last\"");

WriteLiteral(" data-bind=\"click:lastClick,linkbuttonEnable:pageData.scrollKeys.lastEnable\"");

WriteLiteral(" title=\"最后一条\"");

WriteLiteral("></a> \r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"divother\"");

WriteLiteral(" style=\"width:100px; display:none;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-add\'\"");

WriteLiteral(">新增</div>\r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-cross\'\"");

WriteLiteral(">删除</div>\r\n    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-arrow_refresh\'\"");

WriteLiteral(">刷新</div>\r\n</div>  \r\n\r\n<div");

WriteLiteral(" id=\"master\"");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(" data-bind=\"inputwidth:0.9\"");

WriteLiteral(">\r\n");

            
            #line 55 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
 for (var i = 0; i < condtions.Count; i++)
{
    if (i % 3 == 0 && i > 0)
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

            
            #line 62 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
    }

    var item = condtions[i];
    var textPlugin = new List<string>() { "text", "autocomplete", "daterange" };
    var type = item.type.ToString();
    var cls = type == "text" ? "" : ("easyui-" + type);
    var val = textPlugin.Contains(type) ? "value" : (type + "Value");
    //var required = item.required;
    var disable = "";
    var clsDisable = "";
    if (item["readonly"].ToString() == "True")
    {
        disable = ",readOnly : true";
        clsDisable = " readonly";
    }
    else
    {
        disable = textPlugin.Contains(type) ? ",readOnly:readonly" : ("," + type + "ReadOnly : readonly");
    }
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">");

            
            #line 82 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                       Write(item.title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"grid_3 val\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"");

            
            #line 83 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                     Write(val);

            
            #line default
            #line hidden
WriteLiteral(":pageData.form.");

            
            #line 83 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                        Write(item.field);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 83 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                    Write(disable);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 3953), Tuple.Create("\"", 3971)
, Tuple.Create(Tuple.Create("", 3961), Tuple.Create("z-txt", 3961), true)
            
            #line 83 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                               , Tuple.Create(Tuple.Create(" ", 3966), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 3967), false)
);

WriteLiteral(" ");

            
            #line 83 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                 Write(Html.Raw(item.options.ToString() == "" ? "" : "data-options=\"" + item.options + clsDisable + "\""));

            
            #line default
            #line hidden
WriteLiteral("/></div>\r\n");

            
            #line 84 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
}    

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" id=\"tt\"");

WriteLiteral(" class=\"easyui-tabs\"");

WriteLiteral(">  \r\n");

            
            #line 90 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
     for (var i = 0; i < tabs.Count; i++)
    {
        var tab = tabs[i];
   
        if (tab.type.ToString() == "grid")
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("title", Tuple.Create(" title=\"", 4316), Tuple.Create("\"", 4334)
            
            #line 96 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
, Tuple.Create(Tuple.Create("", 4324), Tuple.Create<System.Object, System.Int32>(tab.title
            
            #line default
            #line hidden
, 4324), false)
);

WriteLiteral(">\r\n        <table");

WriteLiteral(" data-bind=\"datagrid:grid");

            
            #line 97 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                   Write(i);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr> \r\n");

            
            #line 100 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 100 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                     foreach (var c in tab.columns)
                    {
                    var hasFmt = c.formatter.ToString() != "";
                    var hasEdt = c.editor.ToString() != "";
                    var hidden = c.Value<bool>("hidden");

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteAttribute("field", Tuple.Create(" field=\"", 4712), Tuple.Create("\"", 4728)
            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
, Tuple.Create(Tuple.Create("", 4720), Tuple.Create<System.Object, System.Int32>(c.field
            
            #line default
            #line hidden
, 4720), false)
);

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                   Write(Html.Raw("\t"));

            
            #line default
            #line hidden
            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                  Write(Html.Raw(hidden ? "hidden=\"true\"" : ""));

            
            #line default
            #line hidden
            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                            Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("sortable=\"");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                     Write(c.sortable.ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\"");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                      Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("align=\"");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                            Write(c.align);

            
            #line default
            #line hidden
WriteLiteral("\"");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                                     Write(Html.Raw("\t"));

            
            #line default
            #line hidden
WriteLiteral("width=\"");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                                                           Write(c.width);

            
            #line default
            #line hidden
WriteLiteral("\" ");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                                                                     Write(Html.Raw(hasEdt ? "editor=\"" + @c.editor + "\"" : ""));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                                                                                                                             Write(Html.Raw(hasFmt ? "formatter=\"" + c.formatter + "\"" : ""));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 105 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                                                                                                                                                                                                                          Write(c.title);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 106 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n        </table>\r\n            \r\n    " +
"    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 5151), Tuple.Create("\"", 5166)
, Tuple.Create(Tuple.Create("", 5156), Tuple.Create("gridtb", 5156), true)
            
            #line 111 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
, Tuple.Create(Tuple.Create("", 5162), Tuple.Create<System.Object, System.Int32>(i
            
            #line default
            #line hidden
, 5162), false)
);

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" data-options=\"iconCls:\'icon-search\',plain:true\"");

WriteLiteral(" data-bind=\"click:readonly()?null:grid");

            
            #line 112 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                   Write(i);

            
            #line default
            #line hidden
WriteLiteral(".addRowClick,linkbuttonDisable:readonly\"");

WriteLiteral(">新增</a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" data-options=\"iconCls:\'icon-edit\',plain:true\"");

WriteLiteral(" data-bind=\"click:readonly()?null:grid");

            
            #line 113 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                 Write(i);

            
            #line default
            #line hidden
WriteLiteral(".onClickRow,linkbuttonDisable:readonly\"");

WriteLiteral(">编辑</a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" data-options=\"iconCls:\'icon-remove\',plain:true\"");

WriteLiteral(" data-bind=\"click:readonly()?null:grid");

            
            #line 114 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                                                                   Write(i);

            
            #line default
            #line hidden
WriteLiteral(".removeRowClick,linkbuttonDisable:readonly\"");

WriteLiteral(">删除</a>\r\n        </div>  \r\n    </div>\r\n");

            
            #line 117 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
        }
        else if (tab.type.ToString() == "form")
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("title", Tuple.Create(" title=\"", 5843), Tuple.Create("\"", 5861)
            
            #line 120 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
, Tuple.Create(Tuple.Create("", 5851), Tuple.Create<System.Object, System.Int32>(tab.title
            
            #line default
            #line hidden
, 5851), false)
);

WriteLiteral(" style=\"padding-top:2px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(" data-bind=\"inputwidth:0.9,autoheight:");

            
            #line 121 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                  Write(tabHeight);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" id = \"form");

            
            #line 121 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                         Write(i);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");

            
            #line 122 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
            
            
            #line default
            #line hidden
            
            #line 122 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
             for (var j = 0; j < tab.columns.Count; j++)
            {
                if (j % 3 == 0 && j > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                ");

WriteLiteral("\r\n");

            
            #line 129 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                }
                var item = tab.columns[j];
                var textPlugin = new List<string>() { "text", "autocomplete", "daterange"};
                var type = item.type.ToString();
                var cls = type == "text" ? "" : ("easyui-" + type);
                var val = textPlugin.Contains(type) ? "value" : (type + "Value");
                var readonlyValue = item["readonly"].ToString() == "True"?"true":"readonly";
                var disable = textPlugin.Contains(type) ? ",readOnly:" + readonlyValue : ("," + type + "ReadOnly:" + readonlyValue);
                var clsDisable = item["readonly"].ToString() == "True" ? "readonly" : "";
  

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"grid_1 lbl\"");

WriteLiteral(">");

            
            #line 139 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                               Write(item.title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"grid_3 val\"");

WriteLiteral("><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"");

            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                             Write(val);

            
            #line default
            #line hidden
WriteLiteral(":pageData.tab");

            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                               Write(i);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                   Write(item.field);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                                                                               Write(disable);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("class", Tuple.Create(" class=\"", 7049), Tuple.Create("\"", 7079)
, Tuple.Create(Tuple.Create("", 7057), Tuple.Create("z-txt", 7057), true)
            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                          , Tuple.Create(Tuple.Create(" ", 7062), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 7063), false)
            
            #line 140 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
                                               , Tuple.Create(Tuple.Create(" ", 7067), Tuple.Create<System.Object, System.Int32>(clsDisable
            
            #line default
            #line hidden
, 7068), false)
);

WriteLiteral("/></div>\r\n");

            
            #line 141 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
            }   

            
            #line default
            #line hidden
WriteLiteral("        </div>     \r\n    </div>\r\n");

            
            #line 144 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("title", Tuple.Create(" title=\"", 7185), Tuple.Create("\"", 7203)
            
            #line 147 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
, Tuple.Create(Tuple.Create("", 7193), Tuple.Create<System.Object, System.Int32>(tab.title
            
            #line default
            #line hidden
, 7193), false)
);

WriteLiteral("></div>\r\n");

            
            #line 148 "..\..\Areas\Sys\Views\Generator\TemplateEditView.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
