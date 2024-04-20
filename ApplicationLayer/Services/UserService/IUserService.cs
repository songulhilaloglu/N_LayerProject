using ApplicationLayer.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.UserService
{
    public interface IUserService
    {
        Task<bool> YeniUyeEkleAsync(YeniUyeDTO yeniUye);
        Task<LoginResultDTO> LoginAsync(LoginDTO login);
        Task LogOutAync();
    }
}
