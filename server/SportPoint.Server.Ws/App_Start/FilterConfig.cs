using System.Web;
using System.Web.Mvc;

namespace SportPoint.Server.Ws
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
