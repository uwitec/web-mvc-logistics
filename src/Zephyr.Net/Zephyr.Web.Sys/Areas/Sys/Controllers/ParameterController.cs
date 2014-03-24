using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Sys.Controllers
{
    public class ParameterController : Controller
    {
        //
        // GET: /Sys/Parameter/

        public ActionResult Index()
        {
            return View();
        }

    }

    public class ParameterApiController : ApiController
    {
        public dynamic Get(RequestWrapper request)
        {
            request.SetJson("{orderby:'ParamCode'}");
            return new sys_parameterService().GetModelListWithPaging(request.ToParamQuery());
        }
 
        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var wrappers = RequestWrapper.InstanceArray(1);
            wrappers[0].SetJson(@"{table:'sys_parameter',where:[{column:'ParamCode',values:'{_id}'}]}");

            var service = new sys_parameterService();
            var result = service.Edit(data,null,wrappers);
        }

    }
}
