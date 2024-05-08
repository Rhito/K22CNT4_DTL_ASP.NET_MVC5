using Microsoft.AspNetCore.Mvc;

namespace Lesson02_lab02_2_DTL.Controllers
{
    public class DtlProductController : Controller
    {
        public IActionResult DtlShowProduct()
        {
            return View();
        }
        // GET: Action sửa sản phẩm
        public IActionResult DtlEditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        //GET: Action chi tiết sản phẩm
        public IActionResult DtlDetailsProduct(string productName, int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}
