using EasyEOrder.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.UserDTO
{
    public class ApplicationUserDto
    {
        public ApplicationUserDto()
        {

        }

        public ApplicationUserDto(MyUser applicationUser)
        {
            Id = applicationUser.Id;
            UserName = applicationUser.UserName;
        }

        public string Id { get; set; }

        public string? UserName { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }
    }
}
