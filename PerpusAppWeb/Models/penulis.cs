//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerpusAppWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class penulis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public penulis()
        {
            this.bukus = new HashSet<buku>();
        }
    
        public int id_penulis { get; set; }
        public string nama_penulis { get; set; }
        public string alamat_penulis { get; set; }
        public string hp_penulis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buku> bukus { get; set; }
    }
}
