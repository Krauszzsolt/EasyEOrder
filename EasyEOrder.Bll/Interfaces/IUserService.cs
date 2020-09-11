using EasyEOrder.Bll.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Interfaces
{
    public interface  IUserService
    {
        Task<AuthenticateResponseDto> AuthenticateAsync(AuthenticateRequestDto model);
        IEnumerable<UserDto> GetAll();
        UserDto GetById(string id);
    }
}
