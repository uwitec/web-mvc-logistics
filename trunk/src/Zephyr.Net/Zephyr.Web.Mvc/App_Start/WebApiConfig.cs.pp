using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Zephyr.Core;
using Zephyr.Web.Mvc;

namespace $rootnamespace$
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            WebApiConfigBase.Register(config);
        }
    }
}
