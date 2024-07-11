using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson12_Ontap.Models;

namespace DtlLesson12_Ontap.Controllers
{
    public class DTL_SACHController : Controller
    {
        private DinhTienLuc_2210900038Entities db = new DinhTienLuc_2210900038Entities();

        // GET: DTL_SACH
        public ActionResult DtlIndex()
        {
            var dTL_SACH = db.DTL_SACH.Include(d => d.DTL_TACGIA);
            return View(dTL_SACH.ToList());
        }

        // GET: DTL_SACH/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_SACH dTL_SACH = db.DTL_SACH.Find(id);
            if (dTL_SACH == null)
            {
                return HttpNotFound();
            }
            return View(dTL_SACH);
        }

        // GET: DTL_SACH/Create
        public ActionResult DtlCreate()
        {
            ViewBag.Dtl_MaTG = new SelectList(db.DTL_TACGIA, "Dtl_MaTG", "Dtl_TenTG");
            return View();
        }

        // POST: DTL_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "Dtl_MaSach,Dtl_TenSach,Dtl_SoTrang,Dtl_NamXB,Dtl_MaTG,Dtl_TrangThai")] DTL_SACH dTL_SACH)
        {
            if (ModelState.IsValid)
            {
                db.DTL_SACH.Add(dTL_SACH);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.Dtl_MaTG = new SelectList(db.DTL_TACGIA, "Dtl_MaTG", "Dtl_TenTG", dTL_SACH.Dtl_MaTG);
            return View(dTL_SACH);
        }

        // GET: DTL_SACH/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_SACH dTL_SACH = db.DTL_SACH.Find(id);
            if (dTL_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Dtl_MaTG = new SelectList(db.DTL_TACGIA, "Dtl_MaTG", "Dtl_TenTG", dTL_SACH.Dtl_MaTG);
            return View(dTL_SACH);
        }

        // POST: DTL_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "Dtl_MaSach,Dtl_TenSach,Dtl_SoTrang,Dtl_NamXB,Dtl_MaTG,Dtl_TrangThai")] DTL_SACH dTL_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dTL_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.Dtl_MaTG = new SelectList(db.DTL_TACGIA, "Dtl_MaTG", "Dtl_TenTG", dTL_SACH.Dtl_MaTG);
            return View(dTL_SACH);
        }

        // GET: DTL_SACH/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_SACH dTL_SACH = db.DTL_SACH.Find(id);
            if (dTL_SACH == null)
            {
                return HttpNotFound();
            }
            return View(dTL_SACH);
        }

        // POST: DTL_SACH/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DtlDeleteConfirmed(string id)
        {
            DTL_SACH dTL_SACH = db.DTL_SACH.Find(id);
            db.DTL_SACH.Remove(dTL_SACH);
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
