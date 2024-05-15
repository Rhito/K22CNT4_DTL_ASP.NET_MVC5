using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dtl_lab04.Models;

namespace Dtl_lab04.Controllers
{
    public class DtlCustomerController : Controller
    {
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view DtlCustomerDetail
        public ActionResult DtlCustomerDetail()
        {
            //tạo một đối tượng Customer ( nhớ using Lab04.Models)
            DtlCustomer customer = new DtlCustomer()
            {
                CustomerId = "2210900038",
                FullName = "Đinh Tiến Lực",
                Email = "Lasnguyen06@gmail.com",
                Address = "k22Cnt4",
                Phone = "0372657743",
                Balance = 152000
            };
            return View(customer);
        }
        public ActionResult DtlCustomerList()
        {
            //tạo một danh sách khách hàng
            List<DtlCustomer> listcustomer = new List<DtlCustomer>(){
                new DtlCustomer(){ CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",Balance = 15200000},
                new DtlCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",Email = "cucdt@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
                new DtlCustomer(){ CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",Email = "thangnt@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
                new DtlCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",Email = "hailn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
};
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }

    }
}