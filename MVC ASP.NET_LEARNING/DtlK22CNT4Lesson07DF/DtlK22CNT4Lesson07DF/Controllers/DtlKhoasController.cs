using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlK22CNT4Lesson07DF.Models;

namespace DtlK22CNT4Lesson07DF.Controllers
{
    public class DtlKhoasController : Controller
    {
        private DtlK22CNT4Lesson07DbEntities1 db = new DtlK22CNT4Lesson07DbEntities1();

        // GET: dtlKhoas
        public ActionResult DtlIndex()
        {
            return View(db.dtlKhoas.ToList());
        }

        // GET: dtlKhoas/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoas.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: dtlKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "dtlMaKH,dtlTenKhoa,dtlTrangThai")] dtlKhoa dtlKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dtlKhoas.Add(dtlKhoa);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoas.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // POST: dtlKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "dtlMaKH,dtlTenKhoa,dtlTrangThai")] dtlKhoa dtlKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(dtlKhoa);
        }

        // GET: dtlKhoas/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlKhoa dtlKhoa = db.dtlKhoas.Find(id);
            if (dtlKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dtlKhoa);
        }

        // POST: dtlKhoas/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dtlKhoa dtlKhoa = db.dtlKhoas.Find(id);
            db.dtlKhoas.Remove(dtlKhoa);
            db.SaveChanges();
            return RedirectToAction("DtlIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
