﻿using System.Web;
using System.Web.Mvc;

namespace Dtl_lab05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
