﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunKod { get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }
        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }

        public bool Durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public ICollection<Operation> Operations { get; set; }


    }

}