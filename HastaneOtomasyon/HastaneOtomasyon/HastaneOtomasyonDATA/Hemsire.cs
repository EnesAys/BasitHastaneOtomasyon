//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneOtomasyonDATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hemsire
    {
        public int HemsireID { get; set; }
        public string HemsireAd { get; set; }
        public string HemsireSoyad { get; set; }
        public int BirimID { get; set; }
        public int DoktorID { get; set; }
    
        public virtual Birim Birim { get; set; }
        public virtual Doktor Doktor { get; set; }
    }
}
