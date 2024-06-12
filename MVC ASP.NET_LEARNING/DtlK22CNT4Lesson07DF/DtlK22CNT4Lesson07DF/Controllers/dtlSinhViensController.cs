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
    public class dtlSinhViensController : Controller
    {
        private DtlK22CNT4Lesson07DbEntities1 db = new DtlK22CNT4Lesson07DbEntities1();

        // GET: dtlSinhViens
        public ActionResult DtlIndex()
        {
            var dtlSinhViens = db.dtlSinhViens.Include(d => d.dtlKhoa);
            return View(dtlSinhViens.ToList());
        }

        // GET: dtlSinhViens/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlSinhVien dtlSinhVien = db.dtlSinhViens.Find(id);
            if (dtlSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dtlSinhVien);
        }

        // GET: dtlSinhViens/Create
        public ActionResult DtlCreate()
        {
            ViewBag.DtlMaKH = new SelectList(db.dtlKhoas, "dtlMaKH", "dtlTenKhoa");
            return View();
        }

        // POST: dtlSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "dtkMaSV,DtlHoSV,DtlTenSV,DtlPhai,DtlEmail,DtlPhone,DtlMaKH,DtlTrangThai")] dtlSinhVien dtlSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.dtlSinhViens.Add(dtlSinhVien);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlMaKH = new SelectList(db.dtlKhoas, "dtlMaKH", "dtlTenKhoa", dtlSinhVien.DtlMaKH);
            return View(dtlSinhVien);
        }

        // GET: dtlSinhViens/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlSinhVien dtlSinhVien = db.dtlSinhViens.Find(id);
            if (dtlSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlMaKH = new SelectList(db.dtlKhoas, "dtlMaKH", "dtlTenKhoa", dtlSinhVien.DtlMaKH);
            return View(dtlSinhVien);
        }

        // POST: dtlSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "dtkMaSV,DtlHoSV,DtlTenSV,DtlPhai,DtlEmail,DtlPhone,DtlMaKH,DtlTrangThai")] dtlSinhVien dtlSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.DtlMaKH = new SelectList(db.dtlKhoas, "dtlMaKH", "dtlTenKhoa", dtlSinhVien.DtlMaKH);
            return View(dtlSinhVien);
        }

        // GET: dtlSinhViens/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtlSinhVien dtlSinhVien = db.dtlSinhViens.Find(id);
            if (dtlSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dtlSinhVien);
        }

        // POST: dtlSinhViens/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dtlSinhVien dtlSinhVien = db.dtlSinhViens.Find(id);
            db.dtlSinhViens.Remove(dtlSinhVien);
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
