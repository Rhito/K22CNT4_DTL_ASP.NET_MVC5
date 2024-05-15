using lab3_2_dtl.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab3_2_dtl.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
