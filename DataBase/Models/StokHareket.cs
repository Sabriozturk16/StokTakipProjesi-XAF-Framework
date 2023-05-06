using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DataBase.Models
{
    public class StokHareket
    {
        [Key]
        public int OID { get; set; }
        [Required]
        public DateTime IslemTarihi { get; set; }
        [Required]

        public IslemTuru IslemTuru { get; set; }
        [Required]

        public double Miktar { get; set; }
        [Required]

        public string Aciklama { get; set; }
        [Required]

        public int? StokKartId { get; set; }
    }

    public enum IslemTuru
    {
        Giriş,
        Çıkış
    }
}
