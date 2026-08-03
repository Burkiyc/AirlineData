using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static AirlineData.Classes.Functions;

namespace AirlineDataV2.DbModels
{
    public class AirlineDbContext : DbContext
    {
        public DbSet<Ucak> Ucaklar { get; set; }
        public DbSet<BakimKaydi> BakimKayitlari { get; set; }
        public DbSet<Personel> Personeler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }
}
