using System.Web;
using System.Web.Mvc;

namespace DtlK22Cnt4Lesson10CB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
