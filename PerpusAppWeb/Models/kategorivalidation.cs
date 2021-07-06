using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerpusAppWeb.Models
{
    [MetadataType(typeof(kategoriMetaData))]
    public partial class kategori
    {
        public class kategoriMetaData
        {
            [DisplayName("Nama Kategori")]
            public string nama_kategori { get; set; }

            [DisplayName("Status Kategori")]
            public string status_kategori { get; set; }
        }
    }
}