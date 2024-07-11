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
    public class DTL_TACGIAController : Controller
    {
        private DinhTienLuc_2210900038Entities db = new DinhTienLuc_2210900038Entities();

        // GET: DTL_TACGIA
        public ActionResult DtlIndex()
        {
            return View(db.DTL_TACGIA.ToList());
        }

        // GET: DTL_TACGIA/Details/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_TACGIA dTL_TACGIA = db.DTL_TACGIA.Find(id);
            if (dTL_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dTL_TACGIA);
        }

        // GET: DTL_TACGIA/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: DTL_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "Dtl_MaTG,Dtl_TenTG")] DTL_TACGIA dTL_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.DTL_TACGIA.Add(dTL_TACGIA);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(dTL_TACGIA);
        }

        // GET: DTL_TACGIA/Edit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_TACGIA dTL_TACGIA = db.DTL_TACGIA.Find(id);
            if (dTL_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dTL_TACGIA);
        }

        // POST: DTL_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "Dtl_MaTG,Dtl_TenTG")] DTL_TACGIA dTL_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dTL_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(dTL_TACGIA);
        }

        // GET: DTL_TACGIA/Delete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DTL_TACGIA dTL_TACGIA = db.DTL_TACGIA.Find(id);
            if (dTL_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dTL_TACGIA);
        }

        // POST: DTL_TACGIA/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DtlDeleteConfirmed(string id)
        {
            DTL_TACGIA dTL_TACGIA = db.DTL_TACGIA.Find(id);
            db.DTL_TACGIA.Remove(dTL_TACGIA);
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
