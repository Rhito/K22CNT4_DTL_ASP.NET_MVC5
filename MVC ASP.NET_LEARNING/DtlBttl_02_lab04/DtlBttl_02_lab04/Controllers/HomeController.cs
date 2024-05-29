using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlBttl_02_lab04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DtlShowImg()
        {
            var imageDirectory = new DirectoryInfo(Server.MapPath("~/Content/Images"));
            var images = imageDirectory.GetFiles().Select(f => f.Name).ToList();
            return View(images);
        }

        // GET: Home/DtlUpload
        public ActionResult DtlUpload()
        {
            return View();
        }

        // POST: Home/Upload
        [HttpPost]
        public ActionResult DtlUpload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Images"), fileName);
                file.SaveAs(path);

                // Optionally, save the file path to the database
                // SaveFilePathToDatabase(path);

                ViewBag.Message = "File uploaded successfully";
            }
            else
            {
                ViewBag.Message = "No file selected";
            }

            return RedirectToAction("DtlShowImg");
        }
    }
}