using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DtlK22Cnt4Lesson10CB.Models;

namespace DtlK22Cnt4Lesson10CB.Controllers
{
    public class DtlAccountsController : Controller
    {
        private DtlK22CNT4Lesson10CBEntities db = new DtlK22CNT4Lesson10CBEntities();

        // GET: DtlAccounts
        public ActionResult DtlIndex()
        {
            
            return View(db.DtlAccounts.ToList());
        }

        // GET: DtlAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlAccount dtlAccount = db.DtlAccounts.Find(id);
            if (dtlAccount == null)
            {
                return HttpNotFound();
            }
            return View(dtlAccount);
        }

        // GET: DtlAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtlAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DtlId,DtlUserName,DtlPassword,DtlFullName,DtlEmail,DtlPhone,DtlActive")] DtlAccount dtlAccount)
        {
            if (ModelState.IsValid)
            {
                db.DtlAccounts.Add(dtlAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtlAccount);
        }

        // GET: DtlAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlAccount dtlAccount = db.DtlAccounts.Find(id);
            if (dtlAccount == null)
            {
                return HttpNotFound();
            }
            return View(dtlAccount);
        }

        // POST: DtlAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DtlId,DtlUserName,DtlPassword,DtlFullName,DtlEmail,DtlPhone,DtlActive")] DtlAccount dtlAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtlAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtlAccount);
        }

        // GET: DtlAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DtlAccount dtlAccount = db.DtlAccounts.Find(id);
            if (dtlAccount == null)
            {
                return HttpNotFound();
            }
            return View(dtlAccount);
        }

        // POST: DtlAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DtlAccount dtlAccount = db.DtlAccounts.Find(id);
            db.DtlAccounts.Remove(dtlAccount);
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
        public ActionResult DtlLogin()
        {
            var dtlModel = new DtlAccount();
            return View();
        }
        [HttpPost]
        public ActionResult DtlLogin(DtlAccount dtlAccount)
        {
            var dtlCheck = db.DtlAccounts.Where(x=>x.DtlUserName.Equals(dtlAccount.DtlUserName) && x.DtlPassword.Equals(dtlAccount.DtlPassword)).FirstOrDefault();
            if (dtlCheck != null)
            {
                // Luu session
                Session["DtlAccount"] = dtlCheck;
                return Redirect("/");
            }
            return View(dtlAccount);
        }

    }
}
