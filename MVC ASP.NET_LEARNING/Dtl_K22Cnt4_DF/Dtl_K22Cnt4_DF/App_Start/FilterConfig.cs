using System.Web;
using System.Web.Mvc;

namespace Dtl_K22Cnt4_DF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
