using DomainLayer.Entities.Concrete;
using InfrastructureLayer.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrascrutctureLayer.EntityTypeConfigurations
{
    public class Kategori_CFG : Base_CFG<Kategori>, IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KategoriAdi)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
            //builder.Property(x => x.EklenmeTarihi)
            //    .HasColumnType("smalldatetime");
            //builder.Property(x => x.GüncellenmeTarihi)
            //    .HasColumnType("smalldatetime");
            //builder.Property(x => x.PasiflestirildiTarihi)
            //    .HasColumnType("smalldatetime");

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
