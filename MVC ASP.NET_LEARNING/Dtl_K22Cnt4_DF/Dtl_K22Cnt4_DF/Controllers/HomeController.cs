using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dtl_K22Cnt4_DF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DtlIndex()
        {
            return View();
        }

        public ActionResult DtlAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DtlContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}