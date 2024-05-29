using Dtl_lab04_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dtl_lab04_2.Models
{
    public class DtlCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
    //định nghĩa giao diện khách hàng
    public interface DtlICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<DtlCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        DtlCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(DtlCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(DtlCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<DtlCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(DtlCustomer cus);
    }
    //định nghĩa lớp CustomerRepository thực thi từ giao diện DtlICustomerRepository
    
}
public class CustomerRepository : DtlICustomerRepository
{
    //khởi tạo danh sách khách hàng
    static readonly List<DtlCustomer> data = new List<DtlCustomer>()
                {
                new DtlCustomer(){ CustomerId = "KH001",
                    FullName = "Trịnh Văn Chung",Address = "Hà Nội",
                    Email = "devmaster.founder@gmail.com",
                    Phone = "0978.611.889",Balance = 15200000},
                new DtlCustomer(){ CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
                    Email = "cucdt@gmail.com",Phone = "0986.767.444",
                    Balance = 2200000},
                new DtlCustomer(){ CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
                    Email = "thangnt@gmail.com",Phone = "0924.656.542",
                    Balance = 1200000},
                new DtlCustomer(){ CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",Address = "Hà Nội",
                    Email = "hailn@gmail.com",Phone = "0996.555.267",
                    Balance = 6200000}
                };
    //thực thi phương thức lấy danh sách khách hàng
    public IList<DtlCustomer> GetCustomers()
    {
        return data;
    }
    //thực thi phương thức tìm khách hàng theo tên
    public IList<DtlCustomer> SearchCustomer(string name)
    {
        return data.Where(c => c.FullName.EndsWith(name)).ToList();
    }
    //thực thi phương thức lấy khách hàng theo Id
    public DtlCustomer GetCustomer(string customerId)
    {
        return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
    }
    //thực thi phương thức thêm khách hàng
    public void AddCustomer(DtlCustomer cus)
    {
        data.Add(cus);
    }
    //thực thi phương thức cập nhật khách hàng
    public void UpdateCustomer(DtlCustomer cus)
    {
        //lấy khách hàng theo id
        var customer = data.FirstOrDefault(c =>
        c.CustomerId.Equals(cus.CustomerId));
        //nếu có thì sửa thông tin
        if (customer != null)
        {
            customer.FullName = cus.FullName;
            customer.Address = cus.Address;
            customer.Email = cus.Email;
            customer.Phone = cus.Phone;
            customer.Balance = cus.Balance;
        }
    }

    //thực thi phương thức xóa khách hàng
    public void DeleteCustomer(DtlCustomer cus)
    {
        data.Remove(cus);
    }
}