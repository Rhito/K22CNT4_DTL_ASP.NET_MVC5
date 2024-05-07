using Microsoft.AspNetCore.Mvc;

namespace Lesson02_DTL.Controllers
{
        /// <summary>
        /// Author: Đinh Tiến Lực
        /// Class: K22CNT4
        /// 
        /// </summary>

    public class DTL_StudentController : Controller
    {
        // GET DTL_Student
        public IActionResult Index()
        {
            // Truyền dữ liệu từ Controller -> View;
            ViewBag.fullName = "Đinh Tiến Lực";
            ViewData["Birthday"] = "24/10/2004";
            TempData["Phone"] = "0372657743";
            return View();
        }
        public IActionResult Details()
        {
            string dtlStr = "";
            dtlStr += "<h3>Họ và tên: Đinh Tiến Lực</h3>";
            dtlStr += "<p>Mã số: 2210900038</p>";
            dtlStr += "<p>Địa chỉ gmail: dinhtienluc120@gmail.com</p>";
            ViewBag.Details = dtlStr;

            return View("chiTiet");
        }
        public IActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper

        public IActionResult AddNewStudent ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewStudent (IFormCollection form)
        {
            // Lấy dữ liệu trên Form
            string fullName = form["fullName"];
            string maSV = form["maSV"];
            string taiKhoan = form["taiKhoan"];
            string matKhau= form["password"];

            string dtlStr = "<hr/><h3>" + fullName + "</h3>";
            dtlStr += "<p>" + maSV;
            dtlStr += "<p>" + taiKhoan;
            dtlStr += "<p>" + matKhau;

            ViewBag.info = dtlStr;
            return View("KetQua");
        }
    }
}
