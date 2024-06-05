using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DtlLesson06CF.Models
{
    public class DtlBookStore : DbContext 
    {
        public DtlBookStore() : base("DtlBookStoreConnectionString") { }

        // Khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<DtlCategory> dtlCategories { get; set; }
        public DbSet<DtlBook> Books { get; set; }   

    }
}