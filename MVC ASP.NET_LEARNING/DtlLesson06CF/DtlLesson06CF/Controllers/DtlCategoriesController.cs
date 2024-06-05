using DtlLesson06CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtlLesson06CF.Controllers
{
    public class DtlCategoriesController : Controller
    {
        private static DtlBookStore dtlDb;
        public DtlCategoriesController()
        {
            dtlDb = new DtlBookStore();
        }
        // GET: DtlCategories
        public ActionResult DtlIndex()
        {
            /*
             * Khởi tạo DbContext :
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET FrameWork
             * trên máy tính và sau đó tạo CSDL
             * 
             *  DtlBookStore dtlDb =  new DtlBookStore();
             */
            var dtlCategories = dtlDb.dtlCategories.ToList();
            return View(dtlCategories);
        }

        public ActionResult DtlCreate()
        {
            var dtlCategory = new DtlCategory();
            return View(dtlCategory);
        }
        [HttpPost]
        public ActionResult DtlCreate(DtlCategory dtlCategory)
        {
            dtlDb.dtlCategories.Add(dtlCategory);
            dtlDb.SaveChanges();
            return RedirectToAction("DtlIndex");
        }
    }
}