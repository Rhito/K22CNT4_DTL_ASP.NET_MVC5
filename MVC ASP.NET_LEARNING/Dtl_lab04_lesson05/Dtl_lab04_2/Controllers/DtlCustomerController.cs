using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dtl_lab04_2.Models;
using static Dtl_lab04_2.Controllers.DtlCustomerController;
namespace Dtl_lab04_2.Controllers
{
    public class DtlCustomerController : Controller
    {
        //khai báo biến CustomerRepository
        static CustomerRepository listCustomer;
        public DtlCustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new CustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult DtlGetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult DtlGetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult DtlDetails(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult DtlCreate()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult DtlCreate(DtlCustomer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("DtlGetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult DtlEdit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult DtlEdit(DtlCustomer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("DtlGetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult DtlDelete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("DtlGetCustomers");
        }
    }
}