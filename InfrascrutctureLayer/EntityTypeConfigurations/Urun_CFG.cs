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
    public class Urun_CFG : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.Property(x => x.UrunAdi)
                 .HasColumnType("varchar")
                 .HasMaxLength(100)
                 .IsRequired();
            builder.Property(x => x.Aciklama)
                 .HasColumnType("varchar")
                 .HasMaxLength(500)
                 .IsRequired(false);
            builder.Property(x => x.Fiyat)
                 .HasColumnType("money")
                 .IsRequired();
            builder.Property(x => x.Resim)
                 .HasColumnType("varchar")
                 .HasMaxLength(100)
                 .IsRequired();
            builder.Property(x => x.UrunVideosu)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired(false);
        }
    }
}
