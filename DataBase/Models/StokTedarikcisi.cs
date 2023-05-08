using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class StokTedarikcisi
    {
        [Key]
        public int OID { get; set; }
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
     
        public virtual StokKart StokKart   { get; set; }
    }
}
