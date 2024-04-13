using DomainLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrascrutctureLayer.EntityTypeConfigurations
{
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(x => x.KategoriAdi)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);


            builder.HasData(
            new Kategori
            {
                KategoriID = 1,
                EklenmeTarihi = DateTime.Now,
                KayitDurumu = DomainLayer.Enums.KayitDurumu.Aktif,
                KategoriAdi = "Elektronik"
            },
            new Kategori
            {
                KategoriID = 2,
                EklenmeTarihi = DateTime.Now,
                KayitDurumu = DomainLayer.Enums.KayitDurumu.Aktif,
                KategoriAdi = "Hediyelik Eşya"
            },
            new Kategori
            {
                KategoriID = 3,
                EklenmeTarihi = DateTime.Now,
                KayitDurumu = DomainLayer.Enums.KayitDurumu.Aktif,
                KategoriAdi = "Hobi"
            });
                
         }
        
    }
}
