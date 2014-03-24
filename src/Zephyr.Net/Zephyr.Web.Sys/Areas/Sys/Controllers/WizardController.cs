using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Web.Mvc;

namespace Zephyr.Web.Sys.Controllers
{
    [WizardFilter]
    [AllowAnonymous]
    [MvcMenuFilter(false)]
    public class WizardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Step1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Step2()
        {
            var form = HttpContext.Request.Form;
            var creator = DbCreatorBase.GetDbCreatorByProvider(form["dbtype"]);
            if (creator == null)
                return Json(new { status = "error", message = "此向导暂时不支持该数据库类型！" });

            creator.name = "default";
            creator.server = form["dbhost"];
            creator.uid = form["uname"];
            creator.pwd = form["pwd"];
            creator.database = form["dbname"];

            var message = creator.Execute();

            if (string.IsNullOrEmpty(message))
            {
                creator.UpdateWebConfig();

                ViewData["Status"] = "success";
                ViewData["Title"] = "已创建数据库";
                ViewData["Message"] = string.Format("已成功在主机{0}上创建了数据库{1}！", creator.server, creator.database);
            }
            else
            {
                ViewData["Status"] = "error";
                ViewData["Title"] = "创建数据库失败";
                ViewData["Message"] = message;
            }
 
            return View();
        }

        public JsonResult Test()
        {
            var form = HttpContext.Request.Form;
            var creator = DbCreatorBase.GetDbCreatorByProvider(form["dbtype"]);
            if(creator == null)
                return Json(new { status = "error", message = "此向导暂时不支持该数据库类型！" });

            creator.server = form["dbhost"];
            creator.uid = form["uname"];
            creator.pwd = form["pwd"];
            creator.database = form["dbname"];

            if (string.IsNullOrEmpty(creator.database))
                return Json(new { status = "error", message = "数据库名不能为空！" });

            if (creator.TestConnectionStringDefaultDatabase())
            {
                if (creator.TestConnectionString())
                    return Json(new { status = "confirm", message = string.Format("数据库{0}已存在！是否要创建在此数据库中？",creator.database) });

                return Json(new { status = "success", message = "连接成功！" });
            }

            return Json(new { status = "error", message = "连接失败，请检查修改设置！" });
        }
    }
}
