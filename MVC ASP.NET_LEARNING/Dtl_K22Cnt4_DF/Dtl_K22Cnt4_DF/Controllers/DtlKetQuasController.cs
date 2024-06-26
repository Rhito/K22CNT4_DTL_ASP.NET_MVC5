using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dtl_K22Cnt4_DF.Models;

namespace Dtl_K22Cnt4_DF.Controllers
{
    public class DtlKetQuasController : Controller
    {
        private QLSinhVienDFEntities2 db = new QLSinhVienDFEntities2();

        // GET: KetQuas
        public ActionResult DtlIndex()
        {
            var ketQuas = db.KetQuas.Include(k => k.MonHoc).Include(k => k.SinhVien);
            return View(ketQuas.ToList());
        }

        // GET: KetQuas/DtlDetails/5
        public ActionResult DtlDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQuas.FirstOrDefault(x=>x.MaSV==id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            return View(ketQua);
        }

        // GET: KetQuas/DtlCreate
        public ActionResult DtlCreate()
        {
            ViewBag.MaMH = new SelectList(db.MonHocs, "MaMH", "TenMH");
            ViewBag.MaSV = new SelectList(db.SinhViens, "MaSV", "MaSV");
            return View();
        }

        // POST: KetQuas/DtlCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlCreate([Bind(Include = "MaSV,MaMH,Diem")] KetQua ketQua)
        {
            if (ModelState.IsValid)
            {
                db.KetQuas.Add(ketQua);
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }

            ViewBag.MaMH = new SelectList(db.MonHocs, "MaMH", "TenMH", ketQua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhViens, "MaSV", "HoSV", ketQua.MaSV);
            return View(ketQua);
        }

        // GET: KetQuas/DtlEdit/5
        public ActionResult DtlEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQuas.FirstOrDefault(x=>x.MaSV==id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMH = new SelectList(db.MonHocs, "MaMH", "TenMH", ketQua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhViens, "MaSV", "HoSV", ketQua.MaSV);
            return View(ketQua);
        }

        // POST: KetQuas/DtlEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtlEdit([Bind(Include = "MaSV,MaMH,Diem")] KetQua ketQua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ketQua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DtlIndex");
            }
            ViewBag.MaMH = new SelectList(db.MonHocs, "MaMH", "TenMH", ketQua.MaMH);
            ViewBag.MaSV = new SelectList(db.SinhViens, "MaSV", "HoSV", ketQua.MaSV);
            return View(ketQua);
        }

        // GET: KetQuas/DtlDelete/5
        public ActionResult DtlDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KetQua ketQua = db.KetQuas.FirstOrDefault(x => x.MaSV == id);
            if (ketQua == null)
            {
                return HttpNotFound();
            }
            return View(ketQua);
        }

        // POST: KetQuas/Delete/5
        [HttpPost, ActionName("DtlDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DtlDeleteConfirmed(string id)
        {
            KetQua ketQua = db.KetQuas.FirstOrDefault(x => x.MaSV == id);
            db.KetQuas.Remove(ketQua);
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
