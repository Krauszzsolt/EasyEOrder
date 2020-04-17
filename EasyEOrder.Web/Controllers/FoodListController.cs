using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyEOrder.Web.Controllers
{
    public class FoodListController : Controller
    {

        private readonly IFoodService _foodService;
        public FoodListController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        // GET: FoodList
        public async Task<IActionResult> Index()
        {
            //ViewData["GetFood"] = (await _foodService.GetFoodsGroupByType()).ToList();
            return View((await _foodService.GetFoodsGroupByType()).ToList());
        }

        // GET: FoodList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodList/Create
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

        // GET: FoodList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodList/Edit/5
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

        // GET: FoodList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodList/Delete/5
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