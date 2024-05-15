using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DtlLesson04.Models;

namespace DtlLesson04.Controllers
{
    public class DtlCustomerController : Controller
    {
        // GET: DtlCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: DtlCustomerDetail
        public ActionResult DtlCustomerDetail() {
            // Tạo dữ đối tượng dữ liệu
            var customer = new DtlCustomer()
            {
                CustomerID = 1,
                FirstName = "Lực",
                LastName = "Đinh Tiến",
                Address = "Hà Nội",
                YearOfBirth = 2004
            };
            ViewBag.Customer = customer;
            return View();
        }

        // GET: DtlListCustomer
        public ActionResult DtlListCustomer()
        {
            var list = new List<DtlCustomer>()
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
            // Đưa dữ liệu ra view bằng ViewBag
            // ViewBag.List = list;

            // Đưa dữ liệu ra view bằng strong typing
            return View(list);
        }
    }
}