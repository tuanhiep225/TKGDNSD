//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HanoiBusSystemManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LuuThong
    {
        public int MaLuuThong { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> Ca { get; set; }
        public Nullable<int> MaXeBuyt { get; set; }
        public Nullable<int> MaTuyenXe { get; set; }
        public Nullable<int> MaTaiXe { get; set; }
        public Nullable<int> MaPhuXe { get; set; }
    
        public virtual PhuXe PhuXe { get; set; }
        public virtual TaiXe TaiXe { get; set; }
        public virtual TuyenXe TuyenXe { get; set; }
        public virtual XeBuyt XeBuyt { get; set; }
    }
}