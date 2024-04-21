using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Models.ViewModels;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.AutoMapper
{
    public class UrunProjeMapper : Profile
    {
        public UrunProjeMapper()
        {
            CreateMap<Urun, UrunEkleDTO>().ReverseMap();
            CreateMap<Urun, UrunGuncelleDTO>().ReverseMap();
            CreateMap<Urun, UrunDetayVM>().ReverseMap();


            CreateMap<YeniUyeDTO, YeniUyeEkleVM>().ReverseMap();

            //CreateMap<List<Urun>, List<UrunVM>>().ReverseMap();
            

        }
    }
}
