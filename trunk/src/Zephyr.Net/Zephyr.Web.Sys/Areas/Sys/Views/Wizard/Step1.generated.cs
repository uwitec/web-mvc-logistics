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

namespace Zephyr.Web.Sys.Areas.Sys.Views.Wizard
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Sys/Views/Wizard/Step1.cshtml")]
    public partial class Step1 : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Step1()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Sys\Views\Wizard\Step1.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteLiteral(">\r\n<head>\r\n<meta");

WriteLiteral(" http-equiv=\"Content-Type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral(" />\r\n<title>配置数据库生成选项</title>\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"css/install.css?ver=3.5.1\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"../wp-includes/css/buttons.css?ver=3.5.1\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        html { background: #f9f9f9; }\r\n        body { background: #fff; color:" +
" #333; font-family:Verdana,宋体,Tahoma; font-size:12px; margin: 2em auto; padding:" +
" 1em 2em; -webkit-border-radius: 3px; border-radius: 3px; border: 1px solid #dfd" +
"fdf; max-width: 700px; }\r\n        a { color: #21759b; text-decoration: none; }\r\n" +
"        a:hover { color: #d54e21; }\r\n        h1 { border-bottom: 1px solid #dada" +
"da; clear: both; color: #666; font: 24px Georgia, \"Times New Roman\", Times, seri" +
"f; margin: 30px 0 0 0; padding: 0; padding-bottom: 7px; }\r\n        h2 { font-siz" +
"e: 16px; }\r\n        p, li, dd, dt { padding-bottom: 2px; font-size: 14px; line-h" +
"eight: 1.5; }\r\n        code, .code { font-size: 14px; }\r\n        ul, ol, dl { pa" +
"dding: 5px 5px 5px 22px; }\r\n        a img { border:0}\r\n        abbr { border: 0;" +
" font-variant: normal; }\r\n        #logo { margin: 6px 0 14px 0; border-bottom: n" +
"one; text-align:center}\r\n        .step { margin: 20px 0 15px; }\r\n        .step, " +
"th { text-align: left; padding: 0; }\r\n        .step .button-large { font-size: 1" +
"4px; }\r\n        textarea { border: 1px solid #dfdfdf; -webkit-border-radius: 3px" +
"; border-radius: 3px; font-family: sans-serif; width:  695px; }\r\n        .form-t" +
"able { border-collapse: collapse; margin-top: 1em; width: 100%; }\r\n        .form" +
"-table td { margin-bottom: 9px; padding: 10px 20px 10px 0; border-bottom: 8px so" +
"lid #fff; font-size: 14px; vertical-align: top}\r\n        .form-table th { font-s" +
"ize: 14px; text-align: left; padding: 16px 20px 10px 0; border-bottom: 8px solid" +
" #fff; width: 140px; vertical-align: top; }\r\n        .form-table code { line-hei" +
"ght: 18px; font-size: 14px; }\r\n        .form-table p { margin: 4px 0 0 0; font-s" +
"ize: 11px; }\r\n        select{ height:25px; }\r\n        .form-table input{ height:" +
"20px; line-height: 20px; font-size: 15px; padding: 2px; border: 1px #dfdfdf soli" +
"d; -webkit-border-radius: 3px; border-radius: 3px; font-family: sans-serif; }\r\n " +
"       .form-table input[type=text],\r\n        .form-table input[type=password] {" +
" width: 206px; }\r\n        .form-table th p { font-weight: normal; }\r\n        .fo" +
"rm-table.install-success td { vertical-align: middle; padding: 16px 20px 10px 0;" +
" }\r\n        .form-table.install-success td p { margin: 0; font-size: 14px; }\r\n  " +
"      .form-table.install-success td code { margin: 0; font-size: 18px; }\r\n     " +
"   #error-page { margin-top: 50px; }\r\n        #error-page p { font-size: 14px; l" +
"ine-height: 18px; margin: 25px 0 20px; }\r\n        #error-page code, .code { font" +
"-family: Consolas, Monaco, monospace; }\r\n        #pass-strength-result { backgro" +
"und-color: #eee; border-color: #ddd !important; border-style: solid; border-widt" +
"h: 1px; margin: 5px 5px 5px 0; padding: 5px; text-align: center; width: 200px; d" +
"isplay: none; }\r\n        #pass-strength-result.bad { background-color: #ffb78c; " +
"border-color: #ff853c !important; }\r\n        #pass-strength-result.good { backgr" +
"ound-color: #ffec8b; border-color: #ffcc00 !important; }\r\n        #pass-strength" +
"-result.short { background-color: #ffa0a0; border-color: #f04040 !important; }\r\n" +
"        #pass-strength-result.strong { background-color: #c3ff88; border-color: " +
"#8dff1c !important; }\r\n        .message { border: 1px solid #e6db55; padding: 0." +
"3em 0.6em; margin: 5px 0 15px; background-color: #ffffe0; }\r\n        /* install-" +
"rtl */\r\n        body.rtl { font-family: Tahoma, arial; }\r\n        .rtl h1 { font" +
"-family: arial; margin: 5px -4px 0 0; }\r\n        .rtl ul,\r\n        .rtl ol { pad" +
"ding: 5px 22px 5px 5px; }\r\n        .button,\r\n        .button-primary,\r\n        ." +
"button-secondary { display: inline-block; text-decoration: none; font-size: 12px" +
"; line-height: 23px; height: 24px; margin: 0; padding: 0 10px 1px; cursor: point" +
"er; border-width: 1px; border-style: solid; -webkit-border-radius: 3px; -webkit-" +
"appearance: none; border-radius: 3px; white-space: nowrap; -webkit-box-sizing: b" +
"order-box; -moz-box-sizing:    border-box; box-sizing:         border-box; }\r\n  " +
"      /* Remove the dotted border on :focus and the extra padding in Firefox */\r" +
"\n        button::-moz-focus-inner,\r\n        input[type=\"reset\"]::-moz-focus-inne" +
"r,\r\n        input[type=\"button\"]::-moz-focus-inner,\r\n        input[type=\"submit\"" +
"]::-moz-focus-inner { border-width: 1px 0; border-style: solid none; border-colo" +
"r: transparent; padding: 0; }\r\n        .button.button-large,\r\n        .button-gr" +
"oup.button-large .button { height: 30px; line-height: 28px; padding: 0 12px 2px;" +
" }\r\n        .button.button-small,\r\n        .button-group.button-small .button { " +
"height: 21px; line-height: 20px; padding: 0 8px 1px; }\r\n        .button.button-h" +
"ero,\r\n        .button-group.button-hero .button { font-size: 14px; height: 46px;" +
" line-height: 44px; padding: 0 36px; }\r\n        .button:active { outline: none; " +
"}\r\n        .button.hidden { display: none; }\r\n        .button{ background: #f3f3" +
"f3; background-image: -webkit-gradient(linear, left top, left bottom, from(#fefe" +
"fe), to(#f4f4f4)); background-image: -webkit-linear-gradient(top, #fefefe, #f4f4" +
"f4); background-image:    -moz-linear-gradient(top, #fefefe, #f4f4f4); backgroun" +
"d-image:      -o-linear-gradient(top, #fefefe, #f4f4f4); background-image:   lin" +
"ear-gradient(to bottom, #fefefe, #f4f4f4); border-color: #bbb; color: #333; text" +
"-shadow: 0 1px 0 #fff; }\r\n        .button.hover,\r\n        .button:hover,\r\n      " +
"  .button.focus,\r\n        .button:focus{ background: #f3f3f3; background-image: " +
"-webkit-gradient(linear, left top, left bottom, from(#fff), to(#f3f3f3)); backgr" +
"ound-image: -webkit-linear-gradient(top, #fff, #f3f3f3); background-image:    -m" +
"oz-linear-gradient(top, #fff, #f3f3f3); background-image:     -ms-linear-gradien" +
"t(top, #fff, #f3f3f3); background-image:      -o-linear-gradient(top, #fff, #f3f" +
"3f3); background-image:   linear-gradient(to bottom, #fff, #f3f3f3); border-colo" +
"r: #999; color: #222; }\r\n        .button.focus,\r\n        .button:focus{ -webkit-" +
"box-shadow: 1px 1px 1px rgba(0,0,0,.2); box-shadow: 1px 1px 1px rgba(0,0,0,.2); " +
"}\r\n        .button.active,\r\n        .button.active:hover,\r\n        .button.activ" +
"e:focus,\r\n        .button:active{ background: #eee; background-image: -webkit-gr" +
"adient(linear, left top, left bottom, from(#f4f4f4), to(#fefefe)); background-im" +
"age: -webkit-linear-gradient(top, #f4f4f4, #fefefe); background-image:    -moz-l" +
"inear-gradient(top, #f4f4f4, #fefefe); background-image:     -ms-linear-gradient" +
"(top, #f4f4f4, #fefefe); background-image:      -o-linear-gradient(top, #f4f4f4," +
" #fefefe); background-image:   linear-gradient(to bottom, #f4f4f4, #fefefe); bor" +
"der-color: #999; color: #333; text-shadow: 0 -1px 0 #fff; -webkit-box-shadow: in" +
"set 0 2px 5px -3px rgba( 0, 0, 0, 0.5 ); box-shadow: inset 0 2px 5px -3px rgba( " +
"0, 0, 0, 0.5 ); }\r\n        .button[disabled],\r\n        .button:disabled,\r\n      " +
"  .button-disabled { color: #aaa !important; border-color: #ddd !important; back" +
"ground-image: -webkit-gradient(linear, left top, left bottom, from(#f9f9f9), to(" +
"#f4f4f4)) !important; background-image: -webkit-linear-gradient(top, #f9f9f9, #f" +
"4f4f4) !important; background-image:    -moz-linear-gradient(top, #f9f9f9, #f4f4" +
"f4) !important; background-image:     -ms-linear-gradient(top, #f9f9f9, #f4f4f4)" +
" !important; background-image:      -o-linear-gradient(top, #f9f9f9, #f4f4f4) !i" +
"mportant; background-image:   linear-gradient(to bottom, #f9f9f9, #f4f4f4) !impo" +
"rtant; -webkit-box-shadow: none !important; box-shadow:         none !important;" +
" text-shadow: 0 1px 0 #fff !important; cursor: default; }\r\n    </style>\r\n   \r\n</" +
"head>\r\n<body >\r\n<h1");

WriteLiteral(" id=\"logo\"");

WriteLiteral("><a");

WriteLiteral(" href=\"http://www.zoewin.com/\"");

WriteLiteral(">数据库配置</a></h1>\r\n<form");

WriteLiteral(" method=\"post\"");

WriteLiteral(" action=\"/sys/wizard/step2\"");

WriteLiteral(">\r\n\t<p>请在下方填写您的数据库连接信息。</p>\r\n\t<table");

WriteLiteral(" class=\"form-table\"");

WriteLiteral(">\r\n\t\t<tr>\r\n\t\t\t<th");

WriteLiteral(" scope=\"row\"");

WriteLiteral("><label");

WriteLiteral(" for=\"dbtype\"");

WriteLiteral(">数据库类型</label></th>\r\n\t\t\t<td> \r\n                <select");

WriteLiteral(" name=\"dbtype\"");

WriteLiteral(" id=\"dbtype\"");

WriteLiteral(" style=\"width:16em\"");

WriteLiteral(" >\r\n                    <option");

WriteLiteral(" value=\"MySql\"");

WriteLiteral(">MySql</option>\r\n                    <option");

WriteLiteral(" value=\"SqlServer\"");

WriteLiteral(" selected=\"selected\"");

WriteLiteral(">SqlServer</option>\r\n                </select>\r\n\t\t\t</td>\r\n\t\t\t<td>目前向导只支持mysql和sql" +
" server自动生成</td>\r\n\t\t</tr>\r\n        <tr>\r\n\t\t\t<th");

WriteLiteral(" scope=\"row\"");

WriteLiteral("><label");

WriteLiteral(" for=\"dbhost\"");

WriteLiteral(">数据库服务器</label></th>\r\n\t\t\t<td><input");

WriteLiteral(" name=\"dbhost\"");

WriteLiteral(" id=\"dbhost\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" value=\".\\sql2005\"");

WriteLiteral(" /></td>\r\n\t\t\t<td>如 ip\\sqlexpress 或 localhost 等 </td>\r\n\t\t</tr>\r\n        <tr>\r\n\t\t\t<" +
"th");

WriteLiteral(" scope=\"row\"");

WriteLiteral("><label");

WriteLiteral(" for=\"uname\"");

WriteLiteral(">用户名</label></th>\r\n\t\t\t<td><input");

WriteLiteral(" name=\"uname\"");

WriteLiteral(" id=\"uname\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" value=\"sa\"");

WriteLiteral(" /></td>\r\n\t\t\t<td>您的数据库用户名</td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n\t\t\t<th");

WriteLiteral(" scope=\"row\"");

WriteLiteral("><label");

WriteLiteral(" for=\"pwd\"");

WriteLiteral(">密码</label></th>\r\n\t\t\t<td><input");

WriteLiteral(" name=\"pwd\"");

WriteLiteral(" id=\"pwd\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" value=\"123456\"");

WriteLiteral(" /></td>\r\n\t\t\t<td>及其登陆密码</td>\r\n\t\t</tr>\r\n        <tr>\r\n\t\t\t<th");

WriteLiteral(" scope=\"row\"");

WriteLiteral("><label");

WriteLiteral(" for=\"dbname\"");

WriteLiteral(">数据库名</label></th>\r\n\t\t\t<td><input");

WriteLiteral(" name=\"dbname\"");

WriteLiteral(" id=\"dbname\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" size=\"25\"");

WriteLiteral(" value=\"Zephyr.Sys\"");

WriteLiteral(" /></td>\r\n\t\t\t<td>纵云权限系统数据库名</td>\r\n\t\t</tr>\r\n\t\r\n\t</table>\r\n\t\t<p");

WriteLiteral(" class=\"step\"");

WriteLiteral(" style=\"text-align:right\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" name=\"forward\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" value=\"上一步\"");

WriteLiteral(" class=\"button button-large\"");

WriteLiteral(" style=\"float:left\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral(" />\r\n            <input");

WriteLiteral(" name=\"test\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" value=\"测试连接\"");

WriteLiteral(" class=\"button button-large\"");

WriteLiteral(" onclick=\"Test();\"");

WriteLiteral(" />\r\n            <input");

WriteLiteral(" name=\"submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" value=\"创建\"");

WriteLiteral(" class=\"button button-large\"");

WriteLiteral(" />\r\n\t\t</p>\r\n</form>\r\n     <script");

WriteAttribute("src", Tuple.Create(" src=\"", 9596), Tuple.Create("\"", 9664)
, Tuple.Create(Tuple.Create("", 9602), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery/jquery-")
, 9602), false)
            
            #line 131 "..\..\Areas\Sys\Views\Wizard\Step1.cshtml"
, Tuple.Create(Tuple.Create("", 9629), Tuple.Create<System.Object, System.Int32>(AppSettings.JqueryVersion
            
            #line default
            #line hidden
, 9629), false)
, Tuple.Create(Tuple.Create("", 9657), Tuple.Create(".min.js", 9657), true)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var connectionTested = false;\r\n        submit = $(\"[type=submit]\");\r\n\r" +
"\n        $(\"input\").change(function () {\r\n            submit.attr(\"disabled\", \"d" +
"isabled\");\r\n        });\r\n\r\n        $(\"select\").change(function () {\r\n           " +
" submit.attr(\"disabled\", \"disabled\");\r\n            var val = $(this).val();\r\n   " +
"         if (val == \"MySql\") {\r\n                $(\'#dbhost\').val(\"localhost\");\r\n" +
"                $(\'#uname\').val(\"root\");\r\n                $(\'#pwd\').val(\"root\");" +
"\r\n                $(\'#dbname\').val(\"Zephyr.Sys\");\r\n            }\r\n            el" +
"se {\r\n                $(\'#dbhost\').val(\".\\\\SQL2005\");\r\n                $(\'#uname" +
"\').val(\"sa\");\r\n                $(\'#pwd\').val(\"123456\");\r\n                $(\'#dbn" +
"ame\').val(\"Zephyr.Sys\");\r\n            }\r\n        });\r\n\r\n        $(\"form\").submit" +
"(function () {\r\n\r\n            if (!connectionTested)\r\n                alert(\"请先测" +
"试连接，测试成功后再创建！\");\r\n            else {\r\n                submit.val(\"正在创建请稍候...\");\r" +
"\n                submit.attr(\"disabled\", \"disabled\");\r\n            }\r\n\r\n        " +
"    return connectionTested;\r\n        });\r\n \r\n        function Test() {\r\n       " +
"     connectionTested = false;\r\n            submit.attr(\"disabled\", \"disabled\");" +
"\r\n            var form = {\r\n                dbtype: $(\'#dbtype\').val(),\r\n       " +
"         dbhost: $(\'#dbhost\').val(),\r\n                uname: $(\'#uname\').val(),\r" +
"\n                pwd: $(\'#pwd\').val(),\r\n                dbname: $(\'#dbname\').val" +
"()\r\n            };\r\n \r\n            $.ajax({\r\n                type: \'POST\',\r\n    " +
"            url: \'/sys/wizard/test\',\r\n                data: form,\r\n             " +
"   success: function (d) {\r\n                    if (d.status == \'success\') {\r\n  " +
"                      connectionTested = true;\r\n                        submit.r" +
"emoveAttr(\"disabled\");\r\n                        alert(\"连接成功！\");\r\n               " +
"     }\r\n                    else if (d.status == \'confirm\')\r\n                   " +
" {\r\n                        if (confirm(d.message))\r\n                        {\r\n" +
"                            connectionTested = true;\r\n                          " +
"  submit.removeAttr(\"disabled\");\r\n                        }\r\n                   " +
" }\r\n                    else{\r\n                        alert(d.message);\r\n      " +
"              }\r\n                },\r\n                error: function (e) { alert" +
"(e.responseText);}\r\n            });\r\n        }\r\n \r\n    </script>\r\n</body>\r\n</htm" +
"l>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591