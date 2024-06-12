using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson07_Lab.Models;

namespace DtlLesson07_Lab.Controllers
{
    public class DtlProductsController : Controller
    {
        private DtlShopContext db = new DtlShopContext();

        // GET: DtlProducts
        public ActionResult DtlIndex()
        {
            return View(db.dtlProducts.ToList());
        }

        // GET: DtlProducts/Details/5
        public ActionResult DtlDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.dtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtlProduct);
        }

        // GET: DtlProducts/Create
        public ActionResult DtlCreate()
        {
            return View();
        }

        // POST: DtlProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "DtlProductId,DtlProductName,DtlPrice")] DtlProduct dtlProduct)
        {
            if (ModelState.IsValid)
            {
                db.dtlProducts.Add(dtlProduct);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(dtlProduct);
        }

        // GET: DtlProducts/Edit/5
        public ActionResult DtlEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.dtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtlProduct);
        }

        // POST: DtlProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "DtlProductId,DtlProductName,DtlPrice")] DtlProduct dtlProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(dtlProduct);
        }

        // GET: DtlProducts/Delete/5
        public ActionResult DtlDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlProduct dtlProduct = db.dtlProducts.Find(id);
            if (dtlProduct == null)
            {
                return HttpNotFound();
            }
            return View(dtlProduct);
        }

        // POST: DtlProducts/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlProduct dtlProduct = db.dtlProducts.Find(id);
            db.dtlProducts.Remove(dtlProduct);
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
