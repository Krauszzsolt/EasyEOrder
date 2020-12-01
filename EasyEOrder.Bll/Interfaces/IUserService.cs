using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.UserDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Interfaces
{
    public interface  IUserService
    {
        Task<ApplicationUserDto> AuthenticateAsync(LoginDto model);
        IEnumerable<ApplicationUserDto> GetAll();
        ApplicationUserDto GetById(string id);
        Task<ApplicationUserDto> RegisterAsync(RegisterDto model);
    }
}
