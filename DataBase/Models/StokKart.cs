﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class StokKart
    {
        private Birim birim;

        public int OID { get; set; }
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public Birim Birim { get => birim; set => birim = value; }
        public KullanımDurumu KullanımDurumu { get; set; }
        public virtual ICollection<StokTedarikcisi> Tedarikçiler { get; set; }
        public virtual ICollection<StokHarekets> StokHarekets { get; set; }
        public double Miktar => StokHarekets.Sum(sh => sh.Miktar);

    }

    public enum KullanımDurumu
    {
        Aktif,
        Pasif
    }
}

