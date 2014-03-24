using System;
using System.Collections;
using System.Text;
using System.Web;

namespace Zephyr.Utils
{
    public class WebHelper
    {
        public static bool SubmitCheckForm()
        {
            bool result;
            if (HttpContext.Current.Request.Form.Get("txt_hiddenToken").Equals(WebHelper.GetToken()))
            {
                WebHelper.SetToken();
                result = true;
            }
            else
            {
                throw new Exception("为了保证表单不重复提交，提交无效!");
            }
            return result;
        }

        public static string GetToken()
        {
            HttpContext context = HttpContext.Current;
            string result;
            if (null != context.Session["Token"])
            {
                result = context.Session["Token"].ToString();
            }
            else
            {
                result = string.Empty;
            }
            return result;
        }

        public static void SetToken()
        {
            HttpContext context = HttpContext.Current;
            context.Session.Add("Token", EncryptHelper.MD5(context.Session.SessionID + DateTime.Now.Ticks.ToString(), 32));
        }
 
    }
}