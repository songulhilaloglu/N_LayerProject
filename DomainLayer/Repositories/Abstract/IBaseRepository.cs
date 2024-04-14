using DomainLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        // Bu bir patterndir, repository patterndir.
        Task EkleAsync(TEntity entity);
        Task<bool> GuncelleAsync(TEntity entity);
        Task<bool> SilAsync(int id);
        Task<TEntity> AraAsync(int id);
        Task<IEnumerable<TEntity>> TumunuListeleAsync();

    }
}
