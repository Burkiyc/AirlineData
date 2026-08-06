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
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<BakimPersonel> BakimPersonel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BakimPersonel>()
                .HasKey(bp => new { bp.BakimId, bp.PersonelId });

            modelBuilder.Entity<BakimKaydi>()
                .HasOne(b => b.Ucak)
                .WithMany(u => u.BakimKayitlari)
                .HasForeignKey(b => b.UcakId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BakimPersonel>()
                .HasOne(bp => bp.BakimKaydi)
                .WithMany(b => b.BakimPersoneller)
                .HasForeignKey(bp => bp.BakimId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
