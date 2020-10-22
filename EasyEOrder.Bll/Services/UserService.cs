using EasyEOrder.Bll.DTOs;
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
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        //private List<UserDto> _users = new List<UserDto>
        //{
        //    new UserDto { Id = "1", FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
        //};

        private readonly AppSettings _appSettings;
        private readonly SignInManager<MyUser> _signInManager;
        private readonly UserManager<MyUser> _userManager;
        public UserService(IOptions<AppSettings> appSettings, SignInManager<MyUser> signInManager, UserManager<MyUser> userManager)
        {
            _appSettings = appSettings.Value;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<AuthenticateResponseDto> AuthenticateAsync(AuthenticateRequestDto model)
        {


            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                if (result.Succeeded)
                {
                    if (user == null) return null;

                    var userDto = new UserDto
                    {

                        Id = user.Id,
                        FirstName = user.UserName,
                        LastName = user.UserName,
                        Username = user.UserName,
                        Password = user.PasswordHash
                    };

                    // authentication successful so generate jwt token
                    var token = generateJwtToken(userDto);

                    return new AuthenticateResponseDto(userDto, token);

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

        public IEnumerable<UserDto> GetAll()
        {
            return _userManager.Users.Select(user => new UserDto
            {
                Id = user.Id,
                FirstName = user.UserName,
                LastName = user.UserName,
                Username = user.UserName,
            });

        }

        public UserDto GetById(string id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.UserName,
                LastName = user.UserName,
                Username = user.UserName,
            };
        }

        // helper methods

        private string generateJwtToken(UserDto user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
