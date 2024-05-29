using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dtl_BaiThiGiuaKy.Models
{
    public class DtlCustomer
    {

        [DisplayName("Mã khách hàng:")]
        public string Dtl_2210900038_CustId { get; set; }
        [DisplayName("Tên khách hàng:")]
        public string Dtl_FullName { get; set; }

        [DisplayName("Địa chỉ:")]
        public string Dtl_Address { get; set; }

        [DisplayName("Email:")]
        public string Dtl_Email { get; set; }

        [DisplayName("SĐT:")]
        public string Dtl_Phone { get; set; }

        [DisplayName("Số dư:")]
        public int Dtl_Balance { get; set; }
    }
}