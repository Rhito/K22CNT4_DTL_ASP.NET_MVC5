using lab01_lesson01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab01_lesson01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ActionResult Index()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Chào mừng bạn đến với ASP.NET MVC 5";
            return View();
        }

        public ActionResult About()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Đây là trang About";
            return View();
        }
    }
}
