using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerpusAppWeb.Models
{
    [MetadataType(typeof(penulisMetaData))]
    public partial class penulis
    {
        public class penulisMetaData
        {
            [DisplayName("Nama Penulis")]
            public string nama_penulis { get; set; }

            [DisplayName("Alamat Penulis")]
            public string alamat_penulis { get; set; }

            [DisplayName("No. HP Penulis")]
            public string hp_penulis { get; set; }
        }
    }
}