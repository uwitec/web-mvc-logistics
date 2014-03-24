using System;
using System.Web;

namespace Zephyr.Utils
{

    public static class ResourceHelper
    {
        public static string GetMessage(string MessageCode)
		{
            string FieldName="";
            if (MessageCode == null || MessageCode.Trim().Equals("")){return "";}
            try{FieldName = HttpContext.GetGlobalResourceObject("Message", MessageCode).ToString();}
            catch{FieldName = MessageCode;}
            return FieldName;
		}

        public static string GetMessage(string MessageCode,params object[] Parms)
        {
            string msg = GetMessage(MessageCode);
            if (Parms != null) msg = String.Format(msg, Parms);
            return msg;
        }

        public static string GetResource(string Resource,string Field)
        {
            string FieldName = "";
            try { FieldName = HttpContext.GetGlobalResourceObject(Resource, Field).ToString();}
            catch {FieldName=Field; }
            return FieldName;
        }

    }
}
