using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Web.Sys.Models;

namespace Zephyr.Web.Sys.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class UserApiController : ApiController
    {
        public dynamic Get(RequestWrapper request) 
        {
            request.SetXml(@"
<settings>
   <where>
        <c column='UserCode' symbol='mapchild' values='{OrganizeCode},sys_userOrganizeMap,OrganizeCode,sys_organize' ignore='empty'></c>
    </where>
    <orderby>UserSeq</orderby>
</settings>");
            var service = new sys_userService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public dynamic GetSettingList(string id)
        {
            var pQuery = ParamQuery.Instance().Where("UserCode", id);
            var service = new sys_userSettingService();
            var result = service.GetModelList(pQuery);
            var keys = result.ToDictionary(x => x.SettingCode).Keys;
            foreach (var item in AppSettings.DefaultUserSettings.Where(x=>!keys.Contains(x.Key)))
            {
                var row = new sys_userSetting() { 
                     SettingCode = item.Key,
                     SettingValue = item.Value,
                     Description = AppSettings.DefaultUserSettingDesc.ContainsKey(item.Key)?
                        AppSettings.DefaultUserSettingDesc[item.Key]:item.Key
                };
                result.Add(row);
            }

            return result.OrderBy(x=>x.SettingCode);
        }

        public dynamic GetOrganizeWithUserCheck(string id)
        {
            var service = new sys_userService();
            return service.GetUserOrganize(id);
        }

        public dynamic GetRoleWithUserCheck(string id)
        {
            var service = new sys_userService();
            return service.GetUserRole(id);
        }

        [System.Web.Http.HttpPost]
        public int PostResetPassword(string id)
        {
            var service = new sys_userService();
            return service.ResetUserPassword(id);
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var wrappers = RequestWrapper.InstanceArray(1);
            wrappers[0].SetJson("{table:'sys_user',where:[{column:'UserCode'}]}");
            var service = new sys_userService();
            var result = service.Edit(data, null, wrappers);
        }

        [System.Web.Http.HttpPost]
        public void EditUserOrganizes(string id, dynamic data)
        {
            var service = new sys_userService();
            service.SaveUserOrganizes(id, data as JToken);
        }

        [System.Web.Http.HttpPost]
        public void EditUserRoles(string id, dynamic data)
        {
            var service = new sys_userService();
            service.SaveUserRoles(id, data as JToken);
        }

        [System.Web.Http.HttpPost]
        public void EditUserSetting(JObject data)
        {
            var wrappers = RequestWrapper.InstanceArray(1);
            wrappers[0].SetJson(@"{table:'sys_userSetting',where:[{column:'ID'}]}");

            var service = new sys_userSettingService();
            var result = service.Edit(data, null, wrappers);
        }
    }
}
