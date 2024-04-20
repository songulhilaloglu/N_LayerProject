using DomainLayer.Entities.Abstract;
using DomainLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly UrunContext _context;
        protected DbSet<TEntity> _table;

        public BaseRepository(UrunContext context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }
        public async Task EkleAsync(TEntity entity)
        {
            entity.EklenmeTarihi = DateTime.Now;
            entity.KayitDurumu = DomainLayer.Enums.KayitDurumu.Aktif;
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<TEntity> AraAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        
        public async Task<bool> GuncelleAsync(TEntity entity)
        {
            entity.GüncellenmeTarihi = DateTime.Now;
            entity.KayitDurumu = DomainLayer.Enums.KayitDurumu.Güncellendi;
            _table.Update(entity);

            bool updateCalistiMi = await _context.SaveChangesAsync() > 0;
            return updateCalistiMi;
            //return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SilAsync(int id)
        {
            TEntity entity = await AraAsync(id);

            entity.PasiflestirildiTarihi = DateTime.Now;
            entity.KayitDurumu = DomainLayer.Enums.KayitDurumu.Pasif;

            _table.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<TEntity>> TumAktifleriListeleAsync()
        {
           return await _table.Where(x => x.KayitDurumu != DomainLayer.Enums.KayitDurumu.Pasif).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> TumPasifleriListeleAsync()
        {
            return await _table.Where(x => x.KayitDurumu == DomainLayer.Enums.KayitDurumu.Pasif).ToListAsync();
        }
    }
}
