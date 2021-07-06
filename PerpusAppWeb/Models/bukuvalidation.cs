using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PerpusAppWeb.Models
{
    [MetadataType(typeof(bukuMetaData))]
    public partial class buku
    {
        public class bukuMetaData
        {
            [DisplayName("Nama Buku")]
            public string nama_buku { get; set; }

            [DisplayName("ID Kategori")]
            public Nullable<int> id_kategori { get; set; }

            [DisplayName("ID Penulis")]
            public Nullable<int> id_penulis { get; set; }

            [DisplayName("ID Penerbit")]
            public Nullable<int> id_penerbit { get; set; }

            [DisplayName("Jumlah Halaman")]
            public string halaman { get; set; }


        }
    }
}