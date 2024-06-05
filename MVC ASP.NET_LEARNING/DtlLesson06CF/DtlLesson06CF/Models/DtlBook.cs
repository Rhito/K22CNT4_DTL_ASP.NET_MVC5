using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DtlLesson06CF.Models
{
    public class DtlBook
    {
        [Key]
        public int DtlId { get; set; }
        public string DtlBookId { get; set; }
        public string DtlTitle { get; set; }
        public string DtlAuthor { get; set; }
        public int DtlYear { get; set; }
        public string DtlPublish { get; set; }
        public string DtlPicture { get; set;}
        public int DtlCategoryId { get; set;}
        // Thuộc tính quan hệ
        public virtual DtlCategory DtlCategory {  get; set; } 

    }
}