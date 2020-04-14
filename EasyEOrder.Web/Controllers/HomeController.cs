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

        public async Task<IActionResult> IndexAsync()
        {
            ViewData["GetFood"] = (await _foodService.GetFoodsGroupByType()).ToList();
            return View((await _foodService.GetFoodsGroupByType()).ToList());
        }

        public IActionResult FoodDetailsaPageAsync()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
