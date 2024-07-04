using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlLesson11_OnTap.Controllers
{
    public class DtlHomeController : Controller
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
            ViewBag.Msv = "221090038";
            ViewBag.FullName = "Đinh Tiến Lực";
            return View();
        }
    }
}