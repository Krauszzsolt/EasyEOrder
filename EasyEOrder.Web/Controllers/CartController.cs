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
    public class CartController : Controller
    {
        private readonly IFoodService _foodService;

        public const string SessionKeyName = "_Ids";

        public CartController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [TempData]
        public string IdsInSession { get; set; }
        // GET: FoodCart
        public async Task<ActionResult> Index()
        {
            List<Guid> Ids = HttpContext.Session.GetString(SessionKeyName) == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(HttpContext.Session.GetString(SessionKeyName));

            List<FoodDto> FoodList = (await _foodService.GetFoodListByIdList(Ids)).ToList();
            ViewBag.SumPrice = FoodList.Count() > 0 ? FoodList.Select(x => x.Price).Sum() : 0;

            return View("Cart", FoodList);
        }

        [HttpPost]
        public ActionResult DeleteCartItem(String id)
        {
            List<Guid> Ids = HttpContext.Session.GetString(SessionKeyName) == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(HttpContext.Session.GetString(SessionKeyName));

            Ids.Remove(new Guid(id));
            HttpContext.Session.SetString(SessionKeyName, JsonConvert.SerializeObject(Ids));

            return RedirectToAction(nameof(CartController.Index), "Cart");
        }



        [HttpPost]
        public ActionResult DeleteCartAllItem(String id)
        {
            List<Guid> Ids = HttpContext.Session.GetString(SessionKeyName) == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(HttpContext.Session.GetString(SessionKeyName));
         
            Ids = new List<Guid>();
            HttpContext.Session.SetString(SessionKeyName, JsonConvert.SerializeObject(Ids));

            return RedirectToAction(nameof(CartController.Index), "Cart");
        }

        [HttpPost]
        public ActionResult AddCart(string id)
        {
            List<Guid> Ids = HttpContext.Session.GetString(SessionKeyName) == null ? new List<Guid>() : JsonConvert.DeserializeObject<List<Guid>>(HttpContext.Session.GetString(SessionKeyName));
            Ids.Add(new Guid(id));
            HttpContext.Session.SetString(SessionKeyName, JsonConvert.SerializeObject(Ids));
            return Json(new { success = true });
        }

    }
}