using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DtlLesson06CF.Models
{
    public class DtlCategory
    {
        [Key]
        public int DtlId { get; set; }
        public string DtlCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<DtlBook> Books { get; set; }
    }
}