using DtlK22Cnt4Lesson10CB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlK22Cnt4Lesson10CB.Controllers
{
    public class DtlHomeController : Controller
    {
        public ActionResult DtlIndex()
        {
            if (Session["DtlAccount"] != null)
            {
                var dtlAccount = Session["DtlAccount"] as DtlAccount;
                ViewBag.FullName = dtlAccount.DtlFullName;
            }
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