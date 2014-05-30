﻿using System;
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
    public class LineController : Controller
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
                    query = "/api/Trade/Line",
                    newkey = "/api/Trade/Line/getnewkey",
                    edit = "/api/Trade/Line/edit" 
                },
                resx = new{
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new{
                    linecd = "" ,
                    line = "" ,
                    bizlist = "" 
                },
                defaultRow = new {
                   
                },
                setting = new{
                    idField = "keyid",
                    postListFields = new string[] { "keyid" ,"linecd" ,"line" ,"bizlist" ,"stateid" }
                }
            };

            return View(model);
        }
    }

    public class LineApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.SetXml(@"
<settings >
    <select>*</select>
    <from>base_line</from>
    <where>
        <c column='linecd'		symbol='like' ignore='empty'></c>   
        <c column='line'		symbol='like' ignore='empty'></c>   
        <c column='bizlist'		symbol='like' ignore='empty'></c>   
    </where>
    <orderby>keyid</orderby>
</settings>");
            var service = new base_lineService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        public string GetNewKey()
        {
            return new base_lineService().GetNewKey("keyid", "maxplus").PadLeft(6, '0'); ;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var tabsWrapper = RequestWrapper.InstanceArray(1);
            tabsWrapper[0].SetXml(@"
<settings>
    <table>base_line</table>
    <where>
        <c column='keyid' symbol='equal'></c>
    </where>
</settings>");
            var service = new base_lineService();
            var result = service.Edit(data,null, tabsWrapper);
        }
    }
}