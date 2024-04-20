using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.ViewModels
{
    public class UrunDetayVM
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public string UrunVideosu { get; set; }
        public int KategoriID { get; set; }


    }
}
