using DtlLesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DtlLesson04.Controllers
{
    public class DtlCustomerScaffoldingController : Controller
    {
        //mockdate
        private static List<DtlCustomer> listCustomer = new List<DtlCustomer>()
        {
            new DtlCustomer()
            {
                CustomerID = 1,
                FirstName = "Lực",
                LastName = "Đinh Tiến",
                Address = "Hà Nội",
                YearOfBirth = 2004
            },
            new DtlCustomer()
            {
                CustomerID = 2,
                FirstName = "Long",
                LastName = "Đinh",
                Address = "Thanh Hóa",
                YearOfBirth = 2001
            },
            new DtlCustomer()
            {
                CustomerID = 3,
                FirstName = "Hoàng",
                LastName = "Phạm Một",
                Address = "Hà Nam",
                YearOfBirth = 2004
            },
            new DtlCustomer()
            {
                CustomerID = 4,
                FirstName = "Thánh",
                LastName = "Cận Trọng",
                Address = "Hà Tây",
                YearOfBirth = 1999
            },
        };

    // GET: DtlCustomerScaffolding\
    // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult DtlCreate()
        {
            var model = new DtlCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult DtlCreate(DtlCustomer model)
        {
            //  Thêm mới đói tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);

            // return View(model);
            // Chuyển về trang danh sách
            return RedirectToAction("Index");
        }

        public ActionResult DtlEdit (int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID == id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult DtlEdit(DtlCustomer model)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerID == model.CustomerID);

            customer.FirstName = model.FirstName;
            customer.LastName = model.LastName;
            customer.Address = model.Address;
            customer.YearOfBirth = model.YearOfBirth;

            return RedirectToAction("Index");
        }

        // GET: //Details/Id
        public ActionResult DtlDetails(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerID == id);
            return View(customer);
        }
        // GET: //Details/Id
        public ActionResult DtlDelete(int id)
        {
            var customer = listCustomer.FirstOrDefault(x =>x.CustomerID == id);
            listCustomer.Remove(customer);
            return RedirectToAction("Index");
        }
    }

}
