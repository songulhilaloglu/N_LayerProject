using DomainLayer.Entities.Concrete;
using InfrascrutctureLayer.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class UrunContext : IdentityDbContext<Uye,Rol, int>
    {
        public UrunContext()
        {

        }
        public UrunContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=UrunDb; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate= true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.ApplyConfiguration(new Urun_CFG());
            builder.ApplyConfiguration(new Uye_CFG());
            builder.ApplyConfiguration(new Sepet_CFG());
            builder.ApplyConfiguration(new Kategori_CFG());
            builder.ApplyConfiguration(new Rol_CFG());

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 1, RoleId = 1 });
        }
    }
}
