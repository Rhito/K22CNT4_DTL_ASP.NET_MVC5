using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Xml.Linq;

namespace DtlLesson07_Lab.Models
{
    public class DtlShopContext : DbContext
    {
        public DtlShopContext() : base("name = DtlShopContext")
        {
            //khởi tạo những gì cần thiết
        }
        public DbSet<DtlProduct> dtlProducts { get; set; }
    }
}