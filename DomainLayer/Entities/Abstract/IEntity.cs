using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Abstract
{
    public interface IEntity
    {
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public DateTime PasiflestirildiTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }


    }
}
