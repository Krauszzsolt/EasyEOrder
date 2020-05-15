using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EasyEOrder.Models;
using EasyEOrder.Dal.Interfaces;
using EasyEOrder.Dal.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace EasyEOrder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoodService _foodService;
        public HomeController(ILogger<HomeController> logger, IFoodService foodService)
        {
            _logger = logger;
            _foodService = foodService;
        }

        public  IActionResult Index()
        {        
            return Redirect("/Identity/Account/Login");
        }


        [Authorize]
        public IActionResult About()
        {
            return View("About");
        }

        [Authorize]
        public IActionResult Contact()
        {
            return View("Contact");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
