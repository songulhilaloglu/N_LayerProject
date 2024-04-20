using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Models.ViewModels;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.UrunService
{
    public interface IUrunService
    {
        Task<UrunDetayVM> UrunBulAsync(int id);
        Task UrunEkleAsync(UrunEkleDTO urunEkleDTO);
        Task<bool> UrunGüncelleAsync(UrunGuncelleDTO urunGuncelleDTO);
        Task<bool> UrunSilAsync(int id);
        Task<IEnumerable<UrunVM>> TumUrunlerAsync();
        Task<IEnumerable<UrunVM>> KategoriyeAitUrunlerAsync(int katID);
        
    }
}
