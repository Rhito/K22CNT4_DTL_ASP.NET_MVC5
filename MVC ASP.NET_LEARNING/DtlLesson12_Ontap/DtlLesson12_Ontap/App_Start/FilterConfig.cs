using System.Web;
using System.Web.Mvc;

namespace DtlLesson12_Ontap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
