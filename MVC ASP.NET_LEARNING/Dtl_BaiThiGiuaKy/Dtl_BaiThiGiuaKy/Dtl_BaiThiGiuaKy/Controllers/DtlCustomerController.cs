using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dtl_BaiThiGiuaKy.Models;
namespace Dtl_BaiThiGiuaKy.Controllers
{
    public class DtlCustomerController : Controller
    {
        private static List<DtlCustomer> dtlCustomers = new List<DtlCustomer>()
        {
            new DtlCustomer()
            {
                Dtl_2210900038_CustId = "2210900038",
                Dtl_FullName = "Đinh Tiến Lực",
                Dtl_Address = "NTU",
                Dtl_Email = "Lasnguyen06@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 50000,
            },new DtlCustomer()
            {
                Dtl_2210900038_CustId = "1",
                Dtl_FullName = "Đinh Tiến Lực1",
                Dtl_Address = "NTU1",
                Dtl_Email = "Lasnguyen061@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 5000,
            },new DtlCustomer()
            {
                Dtl_2210900038_CustId = "2",
                Dtl_FullName = "Đinh Tiến Lực2",
                Dtl_Address = "NTU2",
                Dtl_Email = "Lasnguyen062@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 50002,
            },
            new DtlCustomer()
            {
                Dtl_2210900038_CustId = "3",
                Dtl_FullName = "Đinh Tiến Lực3",
                Dtl_Address = "NTU3",
                Dtl_Email = "Lasnguyen063@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 50003,
            },
            new DtlCustomer()
            {
                Dtl_2210900038_CustId = "4",
                Dtl_FullName = "Đinh Tiến Lực4",
                Dtl_Address = "NTU4",
                Dtl_Email = "Lasnguyen064@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 50004,
            },
            new DtlCustomer()
            {
                Dtl_2210900038_CustId = "5",
                Dtl_FullName = "Đinh Tiến Lực5",
                Dtl_Address = "NTU5",
                Dtl_Email = "Lasnguyen065@fakemail.com",
                Dtl_Phone = "0372657743",
                Dtl_Balance = 500050,
            },
        };

        // GET: DtlCustomer
        public ActionResult DtlIndex()
        {

            return View(dtlCustomers);
        }

        [HttpGet]        
        public ActionResult DtlCreate()
        {
            DtlCustomer dtlCustomer = new DtlCustomer();
            return View(dtlCustomer);
        }

        [HttpPost]
        public ActionResult DtlCreate(DtlCustomer dtlCustomer)
        {
            //  Thêm mới đói tượng khách hàng vào danh sách dữ liệu
            dtlCustomers.Add(dtlCustomer);

            // return View(model);
            // Chuyển về trang danh sách
            return RedirectToAction("DtlIndex");
        }

        [HttpGet]
        public ActionResult DtlEdit(string id)
        {
            var viewDtl = dtlCustomers.FirstOrDefault(x => x.Dtl_2210900038_CustId == id);
            return View(viewDtl);
        }
        [HttpPost]
        public ActionResult DtlEdit(DtlCustomer dtlCustomer)
        {
            var dtlEditCustomer = dtlCustomers.FirstOrDefault(x => x.Dtl_2210900038_CustId == dtlCustomer.Dtl_2210900038_CustId);

            dtlEditCustomer.Dtl_FullName = dtlCustomer.Dtl_FullName;
            dtlEditCustomer.Dtl_Address = dtlCustomer.Dtl_Address;
            dtlEditCustomer.Dtl_Phone = dtlCustomer.Dtl_Phone;
            dtlEditCustomer.Dtl_Email = dtlCustomer.Dtl_Email;
            dtlEditCustomer.Dtl_Balance = dtlCustomer.Dtl_Balance;

            return RedirectToAction("DtlIndex");
        }

        // GET: //Details/Id
        public ActionResult DtlDetails(string id)
        {
            var dtlDetail = dtlCustomers.FirstOrDefault(x => x.Dtl_2210900038_CustId == id);
            return View(dtlDetail);
        }

        // GET: //Details/Id
        public ActionResult DtlDelete(string id)
        {
            var DtlDelete = dtlCustomers.FirstOrDefault(x => x.Dtl_2210900038_CustId == id);
            dtlCustomers.Remove(DtlDelete);
            return RedirectToAction("DtlIndex");
        }
    }
}