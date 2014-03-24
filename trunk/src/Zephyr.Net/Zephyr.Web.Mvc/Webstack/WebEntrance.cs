using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zephyr.Core;
using Zephyr.Utils;

namespace Zephyr.Web.Mvc
{
    public interface IWebEntrance
    {
        object LoginHandler(JObject request);
        object ChangePassword(string passwordold, string passwordnew);
        Dictionary<string, string> GetCurrentUserSettings();
        List<dynamic> GetUserMenus();
        void Logger(string position,string target,string type,object message);
        void OnFrameworkActionExecuting(ActionExecutingContext filterContext);
        bool AuthorizeUserMenu(List<string> urls);
        string GetParameter(string name);
    }

    public class DefaultWebEntrance : IWebEntrance
    {
        public string GetParameter(string name)
        {
            var dict = new Dictionary<string, string>();
            dict["SYS_NAME"] = "业务管理系统";
            dict["SYS_NAME_EN"] = "Business Mangange System";
            dict["SYS_COPYRIGHT"] = "Copyright © 2013 XingHong, All Rights Reserved";

            return dict.ContainsKey(name) ? dict[name] : null;
        }

        public object ChangePassword(string passwordold, string passwordnew)
        {
            return new {status="success", message="修改成功" };
        }

        public bool AuthorizeUserMenu(List<string> urls)
        {
            return true;
        }

        public void OnFrameworkActionExecuting(ActionExecutingContext filterContext)
        {

        }

        public void Logger(string position,string target,string type,object message) 
        {
            ILog Log = LogManager.GetLogger("Operation");
            var user = FormsAuth.GetLoginer().UserName;
            Log.InfoFormat("{0}在位置{1}对{2}做了{3}，数据为{4}",user,position,target,type,JsonConvert.SerializeObject(message));
        }
 
        public object LoginHandler(JObject request)
        {
            var UserCode = request.Value<string>("usercode");
            var Password = request.Value<string>("password");

            //用户名密码检查
            if (String.IsNullOrEmpty(UserCode) || String.IsNullOrEmpty(Password))
                return new { status = "error", message = "用户名或密码不能为空！" };

            //用户名密码验证
            if (UserCode != Password)
                return new { status = "error", message = "用户名或密码不正确！" };

            //取得用户登陆信息
            var Loginer = new LoginerBase() { UserCode = UserCode, UserName = UserCode.ToUpper() };

            //调用框架中的登陆机制
            var effectiveHours = ConfigHelper.GetConfigInt("LoginEffectiveHours",8);
            FormsAuth.SignIn(Loginer, 60 * effectiveHours);
 
            //返回登陆成功
            return new { status = "success", message = "登陆成功！" };
        }

        public Dictionary<string, string> GetCurrentUserSettings()
        {
            var settings = new Dictionary<string, string>();
            settings["theme"] = "default";
            settings["navigation"] = "accordion";
            settings["gridrows"] = "20";
            settings["homeTabTitle"] = "我的桌面";
            settings["homeTabUrl"] = "/home/welcome";
            settings["maxTabCount"] = "10";

            return settings;
        }

        public List<dynamic> GetUserMenus()
        {
            var result = new List<dynamic>();

            var item1 = new JObject();
            item1["MenuCode"] = "10";
            item1["ParentCode"] = "0";
            item1["MenuName"] = "材料管理";
            item1["URL"] = "#";
            item1["IconClass"] = "icon-application_home";
            item1["IconURL"] = "";
            item1["MenuSeq"] = 100;
            item1["IsVisible"] = true;
            item1["IsEnable"] = true;

            var item2 = new JObject();
            item2["MenuCode"] = "0101";
            item2["ParentCode"] = "10";
            item2["MenuName"] = "材料采购单";
            item2["URL"] = "/psi/purchase";
            item2["IconClass"] = "icon-application_osx_add";
            item2["IconURL"] = "";
            item2["MenuSeq"] = 150;
            item2["IsVisible"] = true;
            item2["IsEnable"] = true;

            var item3 = new JObject();
            item3["MenuCode"] = "99";
            item3["ParentCode"] = "0";
            item3["MenuName"] = "系统设置";
            item3["URL"] = "#";
            item3["IconClass"] = "icon-sysset";
            item3["IconURL"] = "";
            item3["MenuSeq"] = 50;
            item3["IsVisible"] = true;
            item3["IsEnable"] = true;

            var item4 = new JObject();
            item4["MenuCode"] = "9901";
            item4["ParentCode"] = "99";
            item4["MenuName"] = "菜单导航";
            item4["URL"] = "/sys/menu";
            item4["IconClass"] = "icon-chart_organisation";
            item4["IconURL"] = "";
            item4["MenuSeq"] = 20;
            item4["IsVisible"] = true;
            item4["IsEnable"] = true;

            result.Add(item1);
            result.Add(item2);
            result.Add(item3);
            result.Add(item4);

            return result;
        }
    }
}