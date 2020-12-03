using EasyEOrder.Api.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using AuthorizeAttribute = EasyEOrder.Api.Helpers.AuthorizeAttribute;
using EasyEOrder.Bll.DTOs.UserDTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyEOrder.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected ApplicationUserDto CurrentUser { get => GetCurrentUser(); }

        protected ApplicationUserDto GetCurrentUser()
        {
            return (ApplicationUserDto)HttpContext.Items["User"];
        }
    }
}
