﻿using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class UrunRepository : BaseRepository<Urun>, IUrunRepository
    {
        public UrunRepository(UrunContext context) : base(context)
        {
        }
    }
}
