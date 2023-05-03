using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Contexs
{
    public class Contex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=StokProjesi;trusted_connection=true;");
        }
        public DbSet<StokTedarikcisi> StokTedarik { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<StokHareket> stokHarekets { get; set; }
        public DbSet<StokKart> stokKarts { get; set; }
        public DbSet<StokTedarikcisi> StokTedarikcisis { get; set; }
    }
}
