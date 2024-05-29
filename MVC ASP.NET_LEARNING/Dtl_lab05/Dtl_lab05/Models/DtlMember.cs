using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dtl_lab05.Models
{
    public class DtlMember
    {
        // Với cách 1 và 2 ta sử dụng khai báo thuộc tính như sau:
        /* public int? Id { get; set; }
         public string DtlUserName { get; set; }
         public string DtlFullName { get; set; }           
         public string DtlPassword { get; set; }
         public int? Age { get; set; }
         public string Email { get; set; }*/

        // Với cách 3 khai báo như sau
        [Required(ErrorMessage = "Hãy nhập số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên đăng nhập")]
        public string DtlUserName { get; set; }

        [Required(ErrorMessage ="Hãy nhập họ và tên")]
        public string DtlFullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        [DataType (DataType.Password)]
        public string DtlPassword { get; set;}

        [Required(ErrorMessage ="Hãy nhập tuổi")]
        [Range(18,50, ErrorMessage ="Tuổi từ 19-50")]
        public int? DtlAge { get; set; }

        [Required(ErrorMessage = "Hãy nhập Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email phải đúng định dạng")]
        public string DtlEmail { get; set; }
    }
}