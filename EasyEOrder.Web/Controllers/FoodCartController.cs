using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.DTOs;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EasyEOrder.Web.Controllers
{
    public class FoodCartController : Controller
    {
        private readonly IFoodService _foodService;

        public const string SessionKeyName = "_Ids";
        public FoodCartController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        [TempData]
        public string IdsInSession { get; set; }
        // GET: FoodCart
        public async Task<ActionResult> Index()
        {

            List<Guid> Ids = HttpContext.Session.GetString(SessionKeyName) == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(HttpContext.Session.GetString(SessionKeyName));

            //Ids.AddRange();

            //Ids.Add(new Guid("fe1ee058-9e79-4544-bf93-026f477fe124"));
            //Ids.Add(new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"));

            List<FoodDto> FoodList = (await _foodService.GetFoodListByIdList(Ids)).ToList();
            ViewBag.SumPrice = FoodList.Count() > 0 ? FoodList.Select(x => x.Price).Sum() : 0;
             //_foodService.GetFoodListByIdList(Ids);
            return View(FoodList);
        }

        // GET: FoodCart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodCart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodCart/Create
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

        // GET: FoodCart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodCart/Edit/5
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

        // GET: FoodCart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodCart/Delete/5
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