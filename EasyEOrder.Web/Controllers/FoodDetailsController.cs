using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EasyEOrder.Web.Controllers
{
    [Authorize]
    public class FoodDetailsController : Controller
    {

        //public const string SessionKeyName = "_Name";
        //public const string SessionKeyAge = "_Age";
        //const string SessionKeyTime = "_Time";

        //public string SessionInfo_Name { get; private set; }
        //public string SessionInfo_Age { get; private set; }
        //public string SessionInfo_CurrentTime { get; private set; }
        //public string SessionInfo_SessionTime { get; private set; }
        //public string SessionInfo_MiddlewareValue { get; private set; }
        [TempData]
        public string IdsInSession { get; set; } 

    

        private readonly IFoodService _foodService;
        public FoodDetailsController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        // GET: FoodDetails
        public async Task<IActionResult> IndexAsync(Guid? id)
        {
           if(id == null)
            {
                return View(await _foodService.GetFooDetails(new Guid("fe1ee058-9e79-4544-bf93-026f477fe123")));
            }
            else
            {
                return View(await _foodService.GetFooDetails(id.Value));
            }
        }

        // GET: FoodDetails/Details/5
        [HttpPost]
        public ActionResult AddCart(Guid id)
        {
            List<Guid> Ids = IdsInSession == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(IdsInSession);
            Ids.Add(id);
            IdsInSession = JsonConvert.SerializeObject(Ids);

            return Json(new { success = true });
            //new List<Guid>();
            //JsonConvert.DeserializeObject<List<PopupMessage>>(TempData["PopupMessages"]);

            //Message.Add(id);

            //Ids.AddRange();
            //    HttpContext.Session.SetString(SessionKeyName, "The Doctor");
            //    HttpContext.Session.SetInt32(SessionKeyAge, 773);

            //var name = HttpContext.Session.GetString(SessionKeyName);
            //var age = HttpContext.Session.GetInt32(SessionKeyAge);
            //Ids.Add(new Guid("fe1ee058-9e79-4544-bf93-026f477fe124"));
            //    Ids.Add(new Guid("fe1ee058-9e79-4544-bf93-026f477fe123"));
            //    HttpContext.Current.Session["test"] = Ids;
            //return View();
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