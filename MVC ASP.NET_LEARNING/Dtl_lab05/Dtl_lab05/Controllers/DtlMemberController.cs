using Dtl_lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dtl_lab05.Controllers
{
    public class DtlMemberController : Controller
    {
        // GET: DtlMember
        public ActionResult DtlIndex()
        {
            return View();
        }

        // GET: DtlMember/DtlCreateOne
        public ActionResult DtlCreateOne() 
        {
            return View();
        }

        // POST: DtlMember/DtlCreateOne
        [HttpPost]
        public ActionResult DtlCreateOne(DtlMember m)
        {
            // Chuyển dữ liệu nhận được tới view DtlDetails
            return RedirectToAction("DtlDetails", m);
        }

        // GET: /DtlMember/CreateTwo
        public ActionResult DtlCreateTwo()
        {
            return View();
        }

        // POST: Dtlmember/DtlCreateTwo
        [HttpPost]
        public ActionResult DtlCreateTwo(DtlMember m)
        {
           if(m.Id == null)
           {
                ViewBag.error = "Hãy nhập mã số";
                return View();
           }
           if(m.DtlUserName == null)
           {
                ViewBag.error = "Hãy nhập mã số";
                return View();
           }
           if(m.DtlFullName == null)
           {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
           }
           if(m.DtlAge == null) 
           {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
           }
           if(m.DtlEmail == null)
           {
                ViewBag.error = "Hãy nhập Email";
                return View();
           }
            string regextPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if(!System.Text.RegularExpressions.Regex.IsMatch(m.DtlEmail, regextPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }

        // nếu không xảy ra lỗi thì chuyển dữ liệu tới View Details
        return View("DtlDetails", m);
        }
        

        //GET: /DtlMember/CreateThree
        public ActionResult DtlCreateThree()
        {
            return View();
        }

        //POST: /DtlMember/CreateThree
        [HttpPost]
        public ActionResult DtlCreateThree(DtlMember m) 
        { 
            // Nếu trạng thái dữ liệu của Model hợp lệ thì dữ liệu tới View Details
            if(ModelState.IsValid)
            {
                return View("DtlDetails", m);

            }else
            {
                return View(); // Quay lại view Three để báo lỗi
            }
        }

        //GET: /DtlMember/Details
        public ActionResult DtlDetails(DtlMember m)
        {
            return View();
        }
    }
}