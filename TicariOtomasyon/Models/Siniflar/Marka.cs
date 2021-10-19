using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Marka
    {
        [Key]
        public int MarkaID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MarkaAd { get; set; }
        public bool Durum { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string MarkaGorsel { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}