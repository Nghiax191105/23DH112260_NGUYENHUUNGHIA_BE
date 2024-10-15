using System.Web;
using System.Web.Mvc;

namespace _23DH112260_NGUYENHUUNGHIA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
