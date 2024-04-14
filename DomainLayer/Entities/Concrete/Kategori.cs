using DomainLayer.Entities.Abstract;
using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Concrete
{
    public class Kategori : IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GüncellenmeTarihi { get; set; }
        public DateTime? PasiflestirildiTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }

        public ICollection<Urun> Urunler { get; set; }
    }
}
