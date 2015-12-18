using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodTruckApp.Presentation.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View("Index", null);
        }
    }
}
