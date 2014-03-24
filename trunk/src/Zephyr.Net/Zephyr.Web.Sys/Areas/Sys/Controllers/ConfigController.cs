using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Zephyr.Web.Sys.Models;
using Zephyr.Web.Mvc;
using System.IO;

namespace Zephyr.Web.Sys.Controllers
{
    public class ConfigController : Controller
    {
        //
        // GET: /Sys/Config/
        [MvcMenuFilter(false)]
        public ActionResult Index()
        {
            var themes = new List<dynamic>();
            var dirbase = new DirectoryInfo(HttpContext.Server.MapPath(string.Format("~/Content/js/easyui/{0}/themes", AppSettings.EasyuiVersion)));
            DirectoryInfo[] dirs = dirbase.GetDirectories();
            foreach (var dir in dirs)
                if (dir.Name != "icons")
                    themes.Add(new {text=dir.Name,value=dir.Name });

            var navigations = new List<dynamic>();
            navigations.Add(new { text = "手风琴-2级(默认)", value = "accordion" });
            //navigations.Add(new { text = "手风琴大图标-2级", value = "accordionbigicon" });
            navigations.Add(new { text = "手风琴树", value = "accordiontree" });
            navigations.Add(new { text = "横向菜单", value = "menubutton" });
            navigations.Add(new { text = "树形结构", value = "tree" });
 
            var model = new {
                dataSource = new{
                    themes=themes,
                    navigations=navigations
                },
                form=  new sys_userService().GetCurrentUserSettings()             
            };

            return View(model);
        }
    }

    public class ConfigApiController : ApiController
    {
        // GET api/sys/config
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sys/config/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/sys/config
        public void Post([FromBody]JObject value)
        {
            if (value == null)
                throw new HttpResponseException(
                    new HttpResponseMessage(HttpStatusCode.NotAcceptable) { Content = new StringContent("配置不可为空") });
          
            var service = new sys_userService();
            service.SaveCurrentUserSettings(value);
        }

        // PUT api/sys/config/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sys/config/5
        public void Delete(int id)
        {
        }
    }
}
