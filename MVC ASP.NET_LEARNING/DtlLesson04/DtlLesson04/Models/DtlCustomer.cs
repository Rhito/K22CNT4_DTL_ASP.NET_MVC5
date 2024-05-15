using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DtlLesson04.Models
{
    public class DtlCustomer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}