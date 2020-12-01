
using EasyEOrder.Bll.DTOs;
using EasyEOrder.Bll.DTOs.UserDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace EasyEOrder.Api.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {

        private readonly List<string> Roles;

        public AuthorizeAttribute()
        {
            Roles = new List<string> { "Administrator", "User" };
        }

        public AuthorizeAttribute(string Role)
        {
            Roles = new List<string> { Role };
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user =  (ApplicationUserDto)context.HttpContext.Items["User"];
            if (user == null || !Roles.Contains(user.Role))
            {
                // not logged in
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
