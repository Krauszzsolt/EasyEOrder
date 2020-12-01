using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.UserDTO;
using EasyEOrder.Bll.Exceptions;
using EasyEOrder.Bll.Helpers;
using EasyEOrder.Bll.Interfaces;
using EasyEOrder.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder.Bll.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly SignInManager<MyUser> _signInManager;
        private readonly UserManager<MyUser> _userManager;
        public UserService(IOptions<AppSettings> appSettings, SignInManager<MyUser> signInManager, UserManager<MyUser> userManager)
        {
            _appSettings = appSettings.Value;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<ApplicationUserDto> AuthenticateAsync(LoginDto model)
        {


            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                if (result.Succeeded)
                {
                    if (user == null) return null;

                    var userDto = new ApplicationUserDto
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Token = GenerateJwtToken(user.Id)
                    };

                    return userDto;

                }
                else
                {
                    return null;
                }
            }

            //_users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            return null;
            // return null if user not found

        }

        public async Task<ApplicationUserDto> RegisterAsync(RegisterDto model)
        {
            var newUser = new MyUser()
            {
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, "User");

                var role = await GetRoleAsync(newUser);

                // authentication successful so generate jwt token
                var token = GenerateJwtToken(newUser.Id);

                var userDto = new ApplicationUserDto(newUser)
                {
                    Token = token,
                    Role = role
                };

                return userDto;
            }
            else
            {
                throw new RegistrationException(string.Join(" ", result.Errors.Select(e => e.Description)));
            }
        }

        public IEnumerable<ApplicationUserDto> GetAll()
        {
            return _userManager.Users.Select(user => new ApplicationUserDto
            {
                Id = user.Id,
                UserName = user.UserName

            });

        }

        public ApplicationUserDto GetById(string id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            return new ApplicationUserDto
            {
                Id = user.Id,
                UserName = user.UserName,
            };
        }

        // helper methods

        private string GenerateJwtToken(string userId)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", userId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private async Task<string> GetRoleAsync(MyUser user)
        {
            // get user roles
            var roles = await _userManager.GetRolesAsync(user);

            if (roles.Any())
            {
                return roles[0];
            }
            else
            {
                return null;
            }

        }


    }
}
