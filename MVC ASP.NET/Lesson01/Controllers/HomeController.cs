using Lesson01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Chào mừng bạn đến với ASP.NET MVC 5";
            ViewBag.name = "Dinh Tien Luc";
            return View();
        }
        public ActionResult About()
        {
            //sử dung ViewBag để đưa dữ liệu ra View
            ViewBag.message = "Đây là trang About";
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult ViewObj()
        {
            return View();
        }
    }
}
