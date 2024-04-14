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
    public class Sepet_CFG : Base_CFG<Sepet>, IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
            base.Configure(builder);
            //builder.Property(x => x.EklenmeTarihi)
            //   .HasColumnType("smalldatetime");
            //builder.Property(x => x.GüncellenmeTarihi)
            //    .HasColumnType("smalldatetime");
            //builder.Property(x => x.PasiflestirildiTarihi)
            //    .HasColumnType("smalldatetime");
        }
    }
}
