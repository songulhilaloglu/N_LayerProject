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
            await _table.AddAsync(entity);

        }

        public Task<TEntity> AraAsync(int id)
        {
            throw new NotImplementedException();
        }

        
        public Task<bool> GuncelleAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SilAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> TumunuListeleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
