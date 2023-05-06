using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class StokHareket
    {
        [Key]
        public int OID { get; set; }
        public DateTime IslemTarihi { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public double Miktar { get; set; }
        public string Aciklama { get; set; }
        public int? StokKartId { get; set; }
    }

    public enum IslemTuru
    {
        Giriş,
        Çıkış
    }
}
