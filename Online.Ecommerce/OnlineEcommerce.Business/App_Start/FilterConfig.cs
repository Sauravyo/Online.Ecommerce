using System.Web;
using System.Web.Mvc;

namespace OnlineEcommerce.Business
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
