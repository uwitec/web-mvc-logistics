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

namespace Zephyr.Web.Mvc.Views.Home
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/_LayoutPartial.cshtml")]
    public partial class LayoutPartial : System.Web.Mvc.WebViewPage<dynamic>
    {
        public LayoutPartial()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\_LayoutPartial.cshtml"
 if (AppLoginer.Navigation == "menubutton")
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" region=\"north\"");

WriteLiteral(" class=\"head-north\"");

WriteLiteral(" split=\"false\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" >\r\n            <span");

WriteLiteral(" class=\"head head-right\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"easyui-linkbutton swich_project\"");

WriteLiteral(" plain=\"true\"");

WriteLiteral(" title=\"切换项目\"");

WriteLiteral(" data-options=\"iconCls:\'icon-flag_france\'\"");

WriteLiteral("></a>\r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"easyui-menubutton\"");

WriteLiteral(" data-options=\"menu:\'#mm_user\',iconCls:\'icon-user\'\"");

WriteLiteral(">当前用户:");

            
            #line 6 "..\..\Views\Home\_LayoutPartial.cshtml"
                                                                                                                          Write(AppLoginer.UserName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <div");

WriteLiteral(" id=\"mm_user\"");

WriteLiteral(" style=\"width:150px;\"");

WriteLiteral(">  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-rainbow\'\"");

WriteLiteral(" class=\"myconfig\"");

WriteLiteral(">个人设置</div>  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-edit\'\"");

WriteLiteral(" class=\"changepwd\"");

WriteLiteral(">修改密码</div>  \r\n                    <div");

WriteLiteral(" class=\"menu-sep\"");

WriteLiteral("></div>  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-user_go\'\"");

WriteLiteral(" class=\"loginOut\"");

WriteLiteral(">安全退出</div>  \r\n                </div> \r\n            </span>\r\n\r\n            <span");

WriteLiteral(" class=\"head-left\"");

WriteLiteral(" >\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\Home\_LayoutPartial.cshtml"
           Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n           ");

WriteLiteral("\r\n            \r\n            <div");

WriteLiteral(" id=\"wnav\"");

WriteLiteral("></div>\r\n        </div>\r\n");

            
            #line 23 "..\..\Views\Home\_LayoutPartial.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" region=\"north\"");

WriteLiteral(" class=\"head-north\"");

WriteLiteral(" split=\"false\"");

WriteLiteral(" border=\"false\"");

WriteLiteral("  >\r\n            <div");

WriteLiteral(" class=\"head head-right\"");

WriteLiteral(" > \r\n                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"easyui-menubutton current-user\"");

WriteLiteral(" data-options=\"menu:\'#mm_user\',iconCls:\'icon-user\'\"");

WriteLiteral(">当前用户:");

            
            #line 28 "..\..\Views\Home\_LayoutPartial.cshtml"
                                                                                                                                       Write(AppLoginer.UserName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <div");

WriteLiteral(" id=\"mm_user\"");

WriteLiteral(" style=\"width:150px;\"");

WriteLiteral(">  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-rainbow\'\"");

WriteLiteral(" class=\"myconfig\"");

WriteLiteral(">个人设置</div>  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-edit\'\"");

WriteLiteral(" class=\"changepwd\"");

WriteLiteral(">修改密码</div>  \r\n                    <div");

WriteLiteral(" class=\"menu-sep\"");

WriteLiteral("></div>  \r\n                    <div");

WriteLiteral(" data-options=\"iconCls:\'icon-user_go\'\"");

WriteLiteral(" class=\"loginOut\"");

WriteLiteral(">安全退出</div>  \r\n                </div>\r\n                &nbsp;  ");

WriteLiteral("\r\n            </div>\r\n            <span");

WriteLiteral(" class=\"head-left\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Home\_LayoutPartial.cshtml"
           Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n            ");

WriteLiteral("\r\n            \r\n        </div>\r\n");

            
            #line 44 "..\..\Views\Home\_LayoutPartial.cshtml"
	

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" region=\"west\"");

WriteLiteral(" split=\"true\"");

WriteLiteral(" title=\"导航菜单\"");

WriteLiteral(" style=\"width:180px;\"");

WriteLiteral(" id=\"west\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"wnav\"");

WriteLiteral("></div>\r\n        </div>\r\n");

            
            #line 48 "..\..\Views\Home\_LayoutPartial.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" split=\"false\"");

WriteLiteral(" class=\"head-south\"");

WriteLiteral(">\r\n\t\t   <div");

WriteLiteral(" class=\"footer\"");

WriteLiteral(">\r\n               <div");

WriteLiteral(" style=\"width: 36%; text-align: left; float: left;\"");

WriteLiteral(">\r\n                    &nbsp;技术支持：厦门兴弘科技有限公司\r\n                </div>\r\n         " +
"       <div");

WriteLiteral(" style=\"width: 28%; text-align: left; float: left;\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 56 "..\..\Views\Home\_LayoutPartial.cshtml"
               Write(Html.Raw(AppSettings.Entrance.GetParameter("SYS_COPYRIGHT")));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" style=\"width: 36%; text-align: right; float: left;\"");

WriteLiteral(">\r\n                   ");

WriteLiteral("\r\n                    &nbsp;<a");

WriteLiteral(" title=\"将问题提交给开发商进行解决\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"http://mail.qq.com/cgi-bin/qm_share?t=qm_mailme&email=vNDVydTJ1c-U2dLbjoyM" +
"hfza08TR3dXQkt-T0Q\"");

WriteLiteral(">问题反馈&nbsp;</a>\r\n                </div>\r\n\t\t   </div>\r\n\t    </div>\r\n\r\n\t    <div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" id=\"mainPanle\"");

WriteLiteral(" style=\"background: #eee; overflow-y:hidden\"");

WriteLiteral(">\r\n\t\t    <div");

WriteLiteral(" id=\"tabs\"");

WriteLiteral(" class=\"easyui-tabs\"");

WriteLiteral("  fit=\"true\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" >\r\n                <div");

WriteAttribute("title", Tuple.Create(" title=\"", 3381), Tuple.Create("\"", 3413)
            
            #line 67 "..\..\Views\Home\_LayoutPartial.cshtml"
, Tuple.Create(Tuple.Create("", 3389), Tuple.Create<System.Object, System.Int32>(AppLoginer.HomeTabTitle
            
            #line default
            #line hidden
, 3389), false)
);

WriteLiteral(" style=\"overflow:hidden;\"");

WriteLiteral(" id=\"home\"");

WriteLiteral("></div>\r\n\t\t    </div>\r\n\t    </div>\r\n \r\n        <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"password-template\"");

WriteLiteral(">\r\n             <div class=\"container_12\" style=\"width:90%;margin:5%;\">\r\n        " +
"        <div class=\"grid_3 lbl\">登陆名：</div>\r\n                <div class=\"grid_9 v" +
"al\"><input type=\"text\" class=\"z-txt readonly \" name=\"UserCode\" value=\"");

            
            #line 74 "..\..\Views\Home\_LayoutPartial.cshtml"
                                                                                                     Write(AppLoginer.UserCode);

            
            #line default
            #line hidden
WriteLiteral(@""" disabled=""disabled""/></div>
                <div class=""grid_3 lbl"">原密码：</div>
                <div class=""grid_9 val""><input type=""password"" class=""z-txt"" name=""PasswordOld"" /></div>
                <div class=""grid_3 lbl"">新密码：</div>
                <div class=""grid_9 val""><input type=""password"" class=""z-txt"" name=""PasswordNew1"" /></div>
                <div class=""grid_3 lbl"">确　认：</div>
                <div class=""grid_9 val""><input type=""password"" class=""z-txt"" name=""PasswordNew2""/></div>
                <div class=""clear""></div>
            </div>

            <div style=""text-align:center;"" class=""z-toolbar-dialog"">
                <a class=""easyui-linkbutton"" data-options=""iconCls:'icon-ok'"" href=""javascript:void(0)""  id=""pwd_confirm"" >确定</a>  
                <a class=""easyui-linkbutton"" data-options=""iconCls:'icon-cancel'"" href=""javascript:void(0)"" id=""pwd_close"">取消</a> 
            </div>
        </script>");

        }
    }
}
#pragma warning restore 1591
