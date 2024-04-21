using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Models.ViewModels;
using AutoMapper;
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
        private readonly IUrunRepository _urunRepo;
        private readonly IMapper _mapper;

        public UrunService(IUrunRepository urunRepo, IMapper mapper)
        {
            _urunRepo = urunRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UrunVM>> KategoriyeAitUrunlerAsync(int katID)
        {
            List<Urun> urunler = _urunRepo.TumAktifleriListeleAsync().Result.Where(x => x.KategoriID == katID).ToList();
            List<UrunVM> urunlerVM = new List<UrunVM>();
            return urunlerVM;
        }

        public async Task<IEnumerable<UrunVM>> TumUrunlerAsync()
        {
            List<Urun> urunler = _urunRepo.TumAktifleriListeleAsync().Result.ToList();
            List<UrunVM> urunlerVM = new List<UrunVM>();
            _mapper.Map(urunler, urunlerVM);

            return urunlerVM;
        }

        public async Task<UrunDetayVM> UrunBulAsync(int id)
        {
            Urun urun = await _urunRepo.AraAsync(id);

            UrunDetayVM urunDetay = new UrunDetayVM();
            _mapper.Map(urun, urunDetay);
            return urunDetay;
        }

        public async Task UrunEkleAsync(UrunEkleDTO urunEkleDTO)
        {
            Urun urun = new Urun();
            _mapper.Map(urunEkleDTO, urun);
            await _urunRepo.EkleAsync(urun);
        }

        public async Task<bool> UrunGüncelleAsync(UrunGuncelleDTO urunGuncelleDTO)
        {
            Urun urun = new Urun();
            _mapper.Map(urunGuncelleDTO, urun);
            return await _urunRepo.GuncelleAsync(urun); 
        }

        public async Task<bool> UrunSilAsync(int id)
        {
            return await _urunRepo.SilAsync(id);
        }
    }
}
