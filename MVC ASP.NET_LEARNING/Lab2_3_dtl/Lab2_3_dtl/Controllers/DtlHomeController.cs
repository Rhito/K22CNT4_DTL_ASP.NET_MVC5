using Lab2_3_dtl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab2_3_dtl.Controllers
{
    public class DtlHomeController : Controller
    {
        private readonly ILogger<DtlHomeController> _logger;

        public DtlHomeController(ILogger<DtlHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DtlNhacViet()
        {
            string[] list = { 
            "sample-3s",
            "sample-6s",
            "sample-9s",
            };
            ViewBag.List = list;
            return View();
        }

        public IActionResult DtlPhatNhac(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        public FileStreamResult TestFileStreamResult(string name)
        {
            string fileName = name + ".mp3";
            string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Content", fileName);
            return File(new FileStream(pathFile, FileMode.Open),
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document", fileName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
