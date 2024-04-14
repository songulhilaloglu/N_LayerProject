﻿using DomainLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.EntityTypeConfigurations
{
    public abstract class Base_CFG<TEntity> where TEntity : class, IEntity
    {
        protected void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.EklenmeTarihi)
                .HasColumnType("smalldatetime");
            builder.Property(x => x.GüncellenmeTarihi)
               .HasColumnType("smalldatetime")
               .IsRequired(false);
            builder.Property(x => x.PasiflestirildiTarihi)
               .HasColumnType("smalldatetime")
               .IsRequired(false); ;
        }
    }
}
