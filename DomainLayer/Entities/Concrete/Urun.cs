using DomainLayer.Entities.Abstract;
using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Concrete
{
    public class Urun : IEntity
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public string UrunVideosu { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GüncellenmeTarihi { get; set; }
        public DateTime? PasiflestirildiTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }


        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }

        public ICollection<Sepet> Sepettekiler { get; set; }
    }
}
