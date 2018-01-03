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
            catFromDb.CatName = "Leo";
            catFromDb.CatAge = 4;
            catFromDb.CatImage = "https://cdn.pixabay.com/photo/2017/11/09/21/41/shotlanskogo-2934720__340.jpg";

           

            var anothercatFromDb = new CatProfile();
            anothercatFromDb.CatName = "Keira";
            anothercatFromDb.CatAge = 6;
            anothercatFromDb.CatImage = "https://cdn.pixabay.com/photo/2017/12/26/12/18/cat-3040345__340.jpg";

           
            using (var catDb = new CatDb())
            {
                //catDb.CatProfiles.Add(catFromDb);
                //catDb.CatProfiles.Add(anothercatFromDb);

                //catDb.SaveChanges();

                var catListFromDb = catDb.CatProfiles.ToList();
                return View(catListFromDb);
            }
            

            

            
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