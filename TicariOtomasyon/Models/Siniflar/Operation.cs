using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Siniflar
{
    public class Operation
    {
        [Key]
        public int OpID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OpKod { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string OpAd { get; set; }
        public int UrunID { get; set; }
        public virtual Urun Urun { get; set; }
      
    }
}