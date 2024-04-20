using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class SepetRepository : BaseRepository<Sepet>, ISepetRepository
    {
        public SepetRepository(UrunContext context) : base(context)
        {
        }
    }
}
