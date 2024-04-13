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
    public class Rol_CFG : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData(new Rol
            {
                Id = 1,
                Name = "Yonetici",
                NormalizedName = "YONETICI",
            },
            new Rol
            {
                Id = 2,
                Name = "Uye",
                NormalizedName = "UYE",
            });
        }
    }
}
