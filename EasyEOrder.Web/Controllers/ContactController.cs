using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyEOrder.Web.Controllers
{
    public class ContactController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}