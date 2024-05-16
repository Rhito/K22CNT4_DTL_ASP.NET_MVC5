using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dtl_lab04.Models
{
    public class DtlCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long Balance { get; set; }
    }
}