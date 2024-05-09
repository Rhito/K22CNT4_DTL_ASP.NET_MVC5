using lab3_3_dtl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace lab3_3_dtl.Controllers
{
    public class HtmlHelperController : Controller
    {
        // GET: HTML_Helper_Methods
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<Country>() {
            new Country(){ID="0",Name="-- Chọn Quốc Gia --"},
            new Country(){ID="VN",Name="Việt Nam"},
            new Country(){ID="AT",Name="AUSTRALIA"},
            new Country(){ID="UK",Name="Anh"},
            new Country(){ID="FR",Name="Pháp"},
            new Country(){ID="US",Name="Mỹ"},
            new Country(){ID="KP",Name="Hàn Quốc"},
            new Country(){ID="HU",Name="Hồng Kong"},
            new Country(){ID="CN",Name="Trung Quốc"},
            };
            return View();
        }

        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            TempData["UName"] = Request.Form["txtUName"];
            TempData["Pass"] = Request.Form["txtPass"];
            TempData["FName"] = Request.Form["txtFName"];
            TempData["Gender"] = Request.Form["Gender"].ToString();
            TempData["Address"] = Request.Form["txtAddress"];
            TempData["Email"] = Request.Form["txtEmail"];
            TempData["Country"] = Request.Form["Country"];

            if (Request.Form["Reading"].ToString().Contains("true")) fvr += "Reading ";
            if (Request.Form["Shopping"].ToString().Contains("true")) fvr +="Shopping ";
            if (Request.Form["Sport"].ToString().Contains("true")) fvr += "Sport";
        
            TempData["Favourist"] = fvr;

            return View();
        }
    }
}

