/*************************************************************************
 * 文件名称 ：FormsAuth.cs                          
 * 描述说明 ：窗体登陆验证
 * 
 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
 **************************************************************************/

using System;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public static class FormsAuth
    {
        public static bool ValidateToken()
        {
            var loginer = GetLoginer();
            var clientToken = loginer.AuthToken;
            var serverToken = GetToken(loginer.UserCode);

            return serverToken.Equals(clientToken);
        }

        public static void SignIn(LoginerBase loginer, int expireMin)
        {
            var loginName = loginer.UserCode;
            loginer.AuthToken = GetToken(loginName);
            var data = JsonConvert.SerializeObject(loginer);

            //创建一个FormsAuthenticationTicket，它包含登录名以及额外的用户数据。
            var ticket = new FormsAuthenticationTicket(2,
                loginName, DateTime.Now, DateTime.Now.AddDays(1), true, data);

            //加密Ticket，变成一个加密的字符串。
            var cookieValue = FormsAuthentication.Encrypt(ticket);

            //根据加密结果创建登录Cookie
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, cookieValue)
                {
                    HttpOnly = true,
                    Secure = FormsAuthentication.RequireSSL,
                    Domain = FormsAuthentication.CookieDomain,
                    Path = FormsAuthentication.FormsCookiePath
                };
            if (expireMin > 0)
                cookie.Expires = DateTime.Now.AddMinutes(expireMin);

            var context = HttpContext.Current;
            if (context == null)
                throw new InvalidOperationException();

            //写登录Cookie
            context.Response.Cookies.Remove(cookie.Name);
            context.Response.Cookies.Add(cookie);
        }

        public static void SingOut()
        {
            FormsAuthentication.SignOut();
        }

        public static LoginerBase GetLoginer()
        {
            return GetLoginer<LoginerBase>();
        }

        public static T GetLoginer<T>() where T : class, new()
        {
            var UserData = new T();
            try
            {
                var context = HttpContext.Current;
                var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
                var ticket = FormsAuthentication.Decrypt(cookie.Value);
                UserData = JsonConvert.DeserializeObject<T>(ticket.UserData);
            }
            catch
            { }

            return UserData;
        }

        private static string GetToken(string loginName)
        {
            //生成用户验证token
            var key = "www.zoewin.com";
            var request = HttpContext.Current.Request;
            var uid = EncryptHelper.AESEncrypt(loginName, key);
            var sid = EncryptHelper.DESEncrypt(GetUniqueID());
            var md5 = EncryptHelper.MD5(uid + sid);
            var token = md5.Substring(Math.Min(loginName.Length, 10), 16);

            return token;
        }

        private static string GetUniqueID()
        {
            var type = App.FormAuthTokenType;
            var context = HttpContext.Current;
            var request = context.Request;

            if (type == "sessionid")
            {
                if (HttpContext.Current.Session == null)
                    throw new Exception("未开启Session支持！");

                //mvc在没有设置session之前，每次sessionI都会变化，以下两句解决这个问题
                SessionHelper.Add("__Activation__", 1);
                SessionHelper.Remove("__Activation__");
                return context.Session.SessionID;
            }

            if (type == "useragent")
                return request.UserAgent + request.UserHostAddress + request.UserHostName + request.Url.Port;

            if (type == "ipadress")
                return RequestHelper.ClientIP;

            return string.Empty;
        }
    }
}
