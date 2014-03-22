using System.Web;
using System.Web.Mvc;

namespace Zephyr.Web.Mvc
{
    public class FilterConfigBase
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MvcHandleErrorAttribute());
            filters.Add(new MvcAuthorizeAttribute());
            filters.Add(new MvcDisposeFilter());
            filters.Add(new MvcMenuFilter());
        }
    }
}