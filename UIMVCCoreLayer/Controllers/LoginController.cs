using ApplicationLayer.Models.DTOs;
using ApplicationLayer.Models.ViewModels;
using ApplicationLayer.Services.UserService;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UIMVCCoreLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult YeniUyeEkle()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> YeniUyeEkle(YeniUyeEkleVM uye)
        {
            if (ModelState.IsValid)
            {
                YeniUyeDTO yeniUyeDTO = new YeniUyeDTO();
                _mapper.Map(uye, yeniUyeDTO);
                await _userService.YeniUyeEkleAsync(yeniUyeDTO);
                return RedirectToAction("Login");
            }
            else 
            return View();
        }

        
        public IActionResult Logout()
        {
            return View();
        }
    }
}
