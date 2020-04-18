using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyEOrder.Web.Controllers
{
    [Authorize]
    public class FoodAddController : Controller
    {
        private readonly IFoodService _foodService;
        public FoodAddController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        // GET: FoodAdd
        public async Task<ActionResult> Index()
        {
           
             var FoodCreateSelectItem = await _foodService.GetFoodCreateSelectItems();
            ViewBag.Menu = FoodCreateSelectItem.Menu;
            ViewBag.Category = FoodCreateSelectItem.Category;
            return View(new FoodCreateDto());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FoodCreateDto newFood)
        {
           _foodService.AddFood(newFood);

            
            return RedirectToAction(nameof(FoodListController.Index), "FoodList");
        }

        // GET: FoodAdd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodAdd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodAdd/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodAdd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodAdd/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodAdd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodAdd/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}