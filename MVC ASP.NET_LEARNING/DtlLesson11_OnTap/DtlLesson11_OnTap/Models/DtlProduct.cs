﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DtlLesson11_OnTap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DtlProduct
    {
        [Display(Name ="Mã sản phẩm")]
        public string DtlId2210900038 { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string DtlProName { get; set; }
        [Display(Name = "Số lượng")]
        public Nullable<int> DtlQty { get; set; }
        [Display(Name = "Giá")]
        public Nullable<double> DtlPrice { get; set; }
        [Display(Name = "Mã danh mục")]
        public Nullable<int> DtlCateId { get; set; }
        [Display(Name = "Trạng thái")]
        public Nullable<bool> DtlActive { get; set; }
    
        public virtual DtlCategory DtlCategory { get; set; }
    }
}