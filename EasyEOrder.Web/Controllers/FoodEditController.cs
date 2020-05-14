using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyEOrder.Web.Controllers
{
    public class FoodEditController : Controller
    {
        // GET: FoodEdit
        public ActionResult Index()
        {
            return View();
        }

        // GET: FoodEdit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodEdit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodEdit/Create
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

        // GET: FoodEdit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodEdit/Edit/5
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

        // GET: FoodEdit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodEdit/Delete/5
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