using System;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Mvc.Controllers
{
    [MvcMenuFilter(false)]
    [WebFrameworkFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AppLoginer.Clear();//清除session中缓存重新取数据
            ViewBag.Title = AppSettings.Entrance.GetParameter("SYS_NAME");
            return View();
        }

        public ActionResult Error() 
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public void Download()
        {
            Exporter.Instance().Download();
        }

        public ContentResult Menus()
        {
            var menus = AppSettings.Entrance.GetUserMenus();
            return Content(JsonConvert.SerializeObject(menus));
        }

        public ContentResult ChangePassword(string PasswordOld, string PasswordNew)
        {
            var result = AppSettings.Entrance.ChangePassword(PasswordOld, PasswordNew);
            return Content(JsonConvert.SerializeObject(result));
        }
    }
}
