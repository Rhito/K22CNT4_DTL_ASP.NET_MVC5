using Microsoft.AspNetCore.Mvc;

namespace Lab02_DTL.Controllers
{
    public class DtlProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
