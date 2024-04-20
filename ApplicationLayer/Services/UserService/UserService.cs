using ApplicationLayer.Models.DTOs;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<Uye> _userManager;
        private readonly SignInManager<Uye> _signInManager;

        public UserService(UserManager<Uye> userManager, SignInManager<Uye> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<LoginResultDTO> LoginAsync(LoginDTO login)
        {
            LoginResultDTO resultDTO = new LoginResultDTO()
            {
                YoneticiMi = false,
                NormalUyeMi = false,
                UyeVarmi = false
            };

            Uye? uye = await _userManager.FindByEmailAsync(login.EPosta);

            if (uye != null)
                return resultDTO;

            if(await _userManager.ChangePasswordAsync(uye, login.Sifre))
            {
                resultDTO.UyeVarmi = true;
                resultDTO.NormalUyeMi = true;

                resultDTO.YoneticiMi = await _userManager.IsInRoleAsync(uye, "Yonetici");

                await _signInManager.SignInAsync(uye, true);
            }

            return resultDTO;
        }

        public Task LoginAsync(YeniUyeDTO yeniUye)
        {
            throw new NotImplementedException();
        }

        public async Task LogOutAync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<bool> YeniUyeEkleAsync(YeniUyeDTO yeniUye)
        {
            Uye uye = new Uye();
            uye.Ad = yeniUye.Ad;
            uye.Soyad = yeniUye.Soyad;
            uye.Adres = yeniUye.Adres;
            uye.UserName = yeniUye.KullaniciAdi;

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            uye.PasswordHash = passwordHasher.HashPassword(uye, yeniUye.Sifre);

            await _userManager.AddToRoleAsync(uye, "Uye");
            var result = await _userManager.CreateAsync(uye);
            return result.Succeeded;

        }

    }
}
