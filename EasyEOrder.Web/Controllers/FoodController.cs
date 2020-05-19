using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EasyEOrder.Web.Controllers
{
    [Authorize]
    public class FoodController : Controller
    {
        public const string SessionKeyName = "_Ids";

        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        // GET: Food
        public async Task<ActionResult> Index()
        {
            return View("Foodlist", (await _foodService.GetFoodsGroupByType()).ToList());
        }

        // GET: Food/Details
        [HttpGet("Food/Details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            return View("FoodDetails", await _foodService.GetFooDetails(id));
        }

        // GET: Food/Create
        [HttpGet("Food/Create/{id?}")]
        public async Task<ActionResult> Create(string id)
        {
            var FoodCreateSelectItem = await _foodService.GetFoodCreateSelectItems();
            ViewBag.Menu = FoodCreateSelectItem.Menu;
            ViewBag.Category = FoodCreateSelectItem.Category;
            ViewBag.Allergen = FoodCreateSelectItem.Allergen;
            if (id == null)
            {
                return View("FoodCreate", new FoodCreateDto());
            }
            else
            {
                return View("FoodCreate", await _foodService.GetFoodForEdit(new Guid(id)));
            }
        }

        // POST: Food/Create
        [HttpPost("Food/Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FoodCreateDto newFood)
        {
            try
            {
                _foodService.AddFood(newFood);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        //// GET: Food/Edit/5
        //public async Task<IActionResult> Edit(Guid id)
        //{
        //    return View();
        //}


        //// POST: Food/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        // POST: Food/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _foodService.DeleteFood(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}