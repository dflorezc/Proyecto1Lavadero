using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFullCar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Index(string Username, string Password)
        {
            return View("Login");
        }

        
        public ActionResult MyIndex(string Username, string Password)
        {
            return View("Login");
        }

    }
}