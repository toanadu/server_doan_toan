//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btl_doan_severAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.GIOHANGs = new HashSet<GIOHANG>();
        }
    
        public string maSP { get; set; }
        public string maTL { get; set; }
        public string tenSP { get; set; }
        public Nullable<int> donGia { get; set; }
        public Nullable<int> soLuong { get; set; }
        public string anh { get; set; }
        public string motaSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
