using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlK22CNT4Lesson07DF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DtlIndex()
        {
            return View();
        }

        public ActionResult DtlAbout()
        {
            ViewBag.Message = "Đinh Tiến Lực";

            return View();
        }

        public ActionResult DtlContact()
        {
            ViewBag.Message = "Đinh Tiến Lực";

            return View();
        }
    }
}