using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Models.ViewModels;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.UrunService
{
    public class UrunService : IUrunService
    {
        private readonly UrunRepository urunRepo;

        public UrunService(UrunRepository _urunRepo)
        {
            urunRepo = _urunRepo;
        }

        public Task<IEnumerable<UrunVM>> KategoriyeAitUrunlerAsync(int katID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UrunVM>> TumUrunlerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UrunDetayVM> UrunBulAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UrunEkleAsync(UrunEkleDTO urunEkleDTO)
        {
            Urun urun = new Urun();
            urun.UrunAdi = urunEkleDTO.UrunAdi;
            urun.Resim = urunEkleDTO.Resim;
            urun.Fiyat = urunEkleDTO.Fiyat;
            urun.Aciklama = urunEkleDTO.Aciklama;
            urun.KategoriID = urunEkleDTO.KategoriID;

            await _urunRepo.EkleAsync(urun);
        }

        public Task<bool> UrunGüncelleAsync(UrunGuncelleDTO urunGuncelleDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UrunSilAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
