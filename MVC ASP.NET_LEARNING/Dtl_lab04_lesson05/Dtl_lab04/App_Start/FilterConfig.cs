﻿using System.Web;
using System.Web.Mvc;

namespace Dtl_lab04
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}