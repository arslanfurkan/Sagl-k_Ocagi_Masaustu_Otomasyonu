//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sevk
    {
        public int SevkId { get; set; }
        public int DosyaNo { get; set; }
        public int PoliklinikId { get; set; }
        public Nullable<int> IslemId { get; set; }
        public string SevkTarihi { get; set; }
        public string Saat { get; set; }
        public Nullable<int> DrKod { get; set; }
        public Nullable<int> Miktar { get; set; }
        public string BirimFiyat { get; set; }
        public Nullable<int> Sira { get; set; }
        public string ToplamTutar { get; set; }
        public Nullable<bool> Taburcu { get; set; }
    
        public virtual Hasta Hasta { get; set; }
        public virtual Islem Islem { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Poliklinik Poliklinik { get; set; }
    }
}
