using DomainLayer.Entities.Abstract;
using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Concrete
{
    public class Sepet : IEntity
    {
        public int SepetID { get; set; }
        public int Adet { get; set; }


        public DateTime EklenmeTarihi { get; set; }
        public DateTime GüncellenmeTarihi { get; set; }
        public DateTime PasiflestirildiTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }


        public int UyeID { get; set; }
        public Uye Uye { get; set; }

        public int UrunID { get; set; }
        public Urun Urun { get; set; }
    }
}
