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
    public class DtlCategoriesController : Controller
    {
        private DtlK22CNT4Lesson11DbEntities db = new DtlK22CNT4Lesson11DbEntities();

        // GET: DtlCategories
        public ActionResult DtlIndex()
        {
            return View(db.DtlCategories.ToList());
        }

        // GET: DtlCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlCategory dtlCategory = db.DtlCategories.Find(id);
            if (dtlCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtlCategory);
        }

        // GET: DtlCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtlCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlId,DtlCateName,DtlStatus")] DtlCategory dtlCategory)
        {
            if (ModelState.IsValid)
            {
                db.DtlCategories.Add(dtlCategory);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            return View(dtlCategory);
        }

        // GET: DtlCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlCategory dtlCategory = db.DtlCategories.Find(id);
            if (dtlCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtlCategory);
        }

        // POST: DtlCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlId,DtlCateName,DtlStatus")] DtlCategory dtlCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            return View(dtlCategory);
        }

        // GET: DtlCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlCategory dtlCategory = db.DtlCategories.Find(id);
            if (dtlCategory == null)
            {
                return HttpNotFound();
            }
            return View(dtlCategory);
        }

        // POST: DtlCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlCategory dtlCategory = db.DtlCategories.Find(id);
            db.DtlCategories.Remove(dtlCategory);
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
