using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;


namespace DtlLesson06.Models
{
    public class DtlSong
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Dtl: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string DtlTitle { get; set; }

        [Required(ErrorMessage = "Dtl: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string DtlAuthor { get; set; }

        [Required(ErrorMessage = "Dtl: Hãy nhập nghệ sĩ")]
        [StringLength(50, MinimumLength =2, ErrorMessage = "Dtl: Tên nghệ sĩ phải có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        [DisplayName("Nghệ sĩ")]
        public string DtlArtist { get; set; }

        [Required(ErrorMessage = "Dtl: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Năm xuất bản phải có 4 ký tự là số")]
        [Range(1890, 2024, ErrorMessage = "Dtl: Năm xuất bản trong khoảng 1890-2024")]
        [DisplayName("Năm xuất bản")]
        public int DtlYearRelease { get; set; }

    }

}