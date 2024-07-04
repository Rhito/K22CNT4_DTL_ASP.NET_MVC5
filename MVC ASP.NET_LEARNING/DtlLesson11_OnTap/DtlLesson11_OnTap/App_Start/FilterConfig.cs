using System.Web;
using System.Web.Mvc;

namespace DtlLesson11_OnTap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
