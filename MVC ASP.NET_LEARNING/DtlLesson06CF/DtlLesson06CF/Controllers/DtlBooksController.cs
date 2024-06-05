using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlLesson06CF.Models;

namespace DtlLesson06CF.Controllers
{
    public class DtlBooksController : Controller
    {
        private DtlBookStore db = new DtlBookStore();

        // GET: DtlBooks
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        // GET: DtlBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.Books.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            return View(dtlBook);
        }

        // GET: DtlBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtlBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlId,DtlBookId,DtlTitle,DtlAuthor,DtlYear,DtlPublish,DtlPicture,DtlCategoryId")] DtlBook dtlBook)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(dtlBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtlBook);
        }

        // GET: DtlBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.Books.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            return View(dtlBook);
        }

        // POST: DtlBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlId,DtlBookId,DtlTitle,DtlAuthor,DtlYear,DtlPublish,DtlPicture,DtlCategoryId")] DtlBook dtlBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtlBook);
        }

        // GET: DtlBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlBook dtlBook = db.Books.Find(id);
            if (dtlBook == null)
            {
                return HttpNotFound();
            }
            return View(dtlBook);
        }

        // POST: DtlBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlBook dtlBook = db.Books.Find(id);
            db.Books.Remove(dtlBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
