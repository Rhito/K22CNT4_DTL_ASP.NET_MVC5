using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson11_OnTap.Models;

namespace DtlLesson11_OnTap.Controllers
{
    public class DtlProductsController : Controller
    {
        private DtlK22CNT4Lesson11DbEntities db = new DtlK22CNT4Lesson11DbEntities();

        // GET: DtlProducts
        public ActionResult DtlIndex()
        {
            var dtlProducts = db.DtlProducts.Include(d => d.DtlCategory);
            return View(dtlProducts.ToList());
        }

        // GET: DtlProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.DtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtlProduct);
        }

        // GET: DtlProducts/Create
        public ActionResult Create()
        {
            ViewBag.DtlCateId = new SelectList(db.DtlCategories, "DtlId", "DtlCateName");
            return View();
        }

        // POST: DtlProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlId2210900038,DtlProName,DtlQty,DtlPrice,DtlCateId,DtlActive")] DtlProduct dtlProduct)
        {
            if (ModelState.IsValid)
            {
                db.DtlProducts.Add(dtlProduct);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.DtlCateId = new SelectList(db.DtlCategories, "DtlId", "DtlCateName", dtlProduct.DtlCateId);
            return View(dtlProduct);
        }

        // GET: DtlProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.DtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.DtlCateId = new SelectList(db.DtlCategories, "DtlId", "DtlCateName", dtlProduct.DtlCateId);
            return View(dtlProduct);
        }

        // POST: DtlProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlId2210900038,DtlProName,DtlQty,DtlPrice,DtlCateId,DtlActive")] DtlProduct dtlProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.DtlCateId = new SelectList(db.DtlCategories, "DtlId", "DtlCateName", dtlProduct.DtlCateId);
            return View(dtlProduct);
        }

        // GET: DtlProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.DtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtlProduct);
        }

        // POST: DtlProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DtlProduct dtlProduct = db.DtlProducts.Find(id);
            db.DtlProducts.Remove(dtlProduct);
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
