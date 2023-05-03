using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class StokHarekets
    {
        public int OID { get; set; }
        public DateTime IslemTarihi { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public double Miktar { get; set; }
        public string Aciklama { get; set; }
    }

    public enum IslemTuru
    {
        Giriş,
        Çıkış
    }
}
