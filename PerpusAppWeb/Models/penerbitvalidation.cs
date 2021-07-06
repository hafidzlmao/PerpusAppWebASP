using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerpusAppWeb.Models
{
    [MetadataType(typeof(penerbitMetaData))]
    public partial class penerbit
    {
        public class penerbitMetaData
        {
            [DisplayName("Nama Penerbit")]
            public string nama_penerbit { get; set; }

            [DisplayName("Alamat Penerbit")]
            public string alamat_penerbit { get; set; }

            [DisplayName("No. HP Penerbit")]
            public string hp_penerbit { get; set; }
        }
    }
}