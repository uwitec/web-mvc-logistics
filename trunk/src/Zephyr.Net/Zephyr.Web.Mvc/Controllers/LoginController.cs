using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Utils;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mvc.Controllers
{
    [AllowAnonymous]
    [MvcMenuFilter(false)]
    [WebFrameworkFilter]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CnName = AppSettings.Entrance.GetParameter("SYS_NAME");
            ViewBag.EnName = AppSettings.Entrance.GetParameter("SYS_NAME_EN");
            return View();
        }
  
        public JsonResult DoAction(JObject request)
        {
            var message = AppSettings.Entrance.LoginHandler(request);
            return Json(message, JsonRequestBehavior.DenyGet);
        }

        public ActionResult Logout()
        {
            FormsAuth.SingOut();
            return Redirect("~/Login");
        }
    }
}
