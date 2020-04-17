using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyEOrder.Web.Controllers
{
    public class FoodDetailsController : Controller
    {
        private readonly IFoodService _foodService;
        public FoodDetailsController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        // GET: FoodDetails
        public async Task<IActionResult> IndexAsync()
        {

            return View(await _foodService.GetFooDetails(new Guid("fe1ee058-9e79-4544-bf93-026f477fe123")));
        }

        // GET: FoodDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodDetails/Create
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

        // GET: FoodDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodDetails/Edit/5
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

        // GET: FoodDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodDetails/Delete/5
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