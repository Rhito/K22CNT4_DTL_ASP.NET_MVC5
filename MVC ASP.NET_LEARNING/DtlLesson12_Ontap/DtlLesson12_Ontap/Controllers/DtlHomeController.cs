using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlLesson12_Ontap.Controllers
{
    public class DtlHomeController : Controller
    {
        public ActionResult DtlIndex()
        {
            return View();
        }

        public ActionResult DtlAbout()
        {
            ViewBag.Class = "K22CNT4";
            ViewBag.Name = "Đinh Tiến Lực";
            ViewBag.MSV = "2210900038";

            return View();
        }

        public ActionResult DtlContact()
        {
            return View();
        }
    }
}