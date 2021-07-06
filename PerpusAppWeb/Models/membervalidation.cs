using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerpusAppWeb.Models
{
    [MetadataType(typeof(memberMetaData))]
    public partial class member
    {
        public class memberMetaData
        {
            [DisplayName("Nama Member")]
            public string nama_member { get; set; }

            [DisplayName("Alamat Member")]
            public string alamat_member { get; set; }

            [DisplayName("No. HP Member")]
            public string hp_member { get; set; }
        }
    }
}