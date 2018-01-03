using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var catFromDb = new CatProfile();
            return View(catFromDb);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts for this webpage creators";

            return View();
        }
    }
}