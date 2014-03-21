/*************************************************************************
 * 文件名称 ：ApiData.cs                          
 * 描述说明 ：取得API数据
 * 
 

 * 
 * 版权信息 : Copyright (c) 2013 厦门兴弘科技有限公司
**************************************************************************/

using System;
using System.Dynamic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zephyr.Utils;

namespace Zephyr.Core
{
    public class ApiData : IDataGetter
    {
        public object GetData(HttpContext context)
        {
            dynamic data = null;

            var url = context.Request.Form["dataAction"];
            var param = JsonConvert.DeserializeObject<dynamic>(context.Request.Form["dataParams"]);

            var route = url.Replace("/api/", "").Split('/'); // route[0]=mms,route[1]=send,route[2]=get
            var type = Type.GetType(String.Format("Zephyr.Web.{0}.Controllers.{1}ApiController,Zephyr.Web.Mms", route), false, true);
            if (type != null)
            {
                var instance = Activator.CreateInstance(type);

                var action = route.Length > 2 ? route[2] : "Get";
                var methodInfo = type.GetMethod(action);
                var parameters = new object[] { new RequestWrapper().SetValue(param) };
                data = methodInfo.Invoke(instance, parameters);

                if (data.GetType() == typeof(ExpandoObject))
                {
                    if ((data as ExpandoObject).Where(x => x.Key == "rows").Count() > 0)
                        data = data.rows;
                }
            }

            return data;
        }
    }
}
