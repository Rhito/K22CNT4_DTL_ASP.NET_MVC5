using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlLab06._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //đáp ứng hành động Post trên form
        [HttpPost]
        //không validate đầu vào
        [ValidateInput(false)]
        public ActionResult Index(string picture, string detail)
        {
            ViewBag.picture = picture;
            ViewBag.detail = detail;
            //chuyển tới view Detail để hiển thị
            return View("Detail");
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}