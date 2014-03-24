/*************************************************************************
 * 文件名称 ：CodeController.cs                          
 * 描述说明 ：字典控制器类
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using Zephyr.Web.Sys.Models;
using Zephyr.Core;

namespace Zephyr.Web.Sys.Controllers
{
    public class CodeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class CodeApiController : ApiController
    {
        
        public dynamic GetCodeType(RequestWrapper request)
        {
            request.SetJson(@"{
where:[
{column:'CodeType',ignore:'empty'},
{column:'CodeTypeName',symbol:'like',ignore:'empty'}
],
orderby:'Seq,CodeType'
}");
            var result =  new sys_codeTypeService().GetDynamicListWithPaging(request.ToParamQuery());
            return result;
        }

        public dynamic Get(RequestWrapper request)
        {
            request.SetJson("{where:[{column:'CodeType',ignore:'empty'}],orderby:'Seq'}");
            var service = new sys_codeService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode()
        {
            var service = new sys_codeService();
            return service.GetNewKey("Code", "maxplus").PadLeft(3,'0');
        }


        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var wrappers = RequestWrapper.InstanceArray(1);
            wrappers[0].SetJson("{table:'sys_code',where:[{column:'Code'}]}");

            var service = new sys_codeService();
            var result = service.Edit(data,null,wrappers);
        }

        [System.Web.Http.HttpPost]
        public void EditCodeType(dynamic data)
        {
            var wrappers = RequestWrapper.InstanceArray(1);
            wrappers[0].SetJson("{table:'sys_codeType',where:[{column:'CodeType'}]}");

            var service = new sys_codeTypeService();
            var result = service.Edit(data, null, wrappers);
        }
    }
}
