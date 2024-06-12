using System.Web;
using System.Web.Mvc;

namespace DtlK22CNT4Lesson07DF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
