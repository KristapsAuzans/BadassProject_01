using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;
    using System.Data.Entity;
    using System.IO;
    using static CatDatingSite.Models.UploadedFiles;

    public class CatsController : Controller
    {
        // GET: Cats
        public ActionResult Index()
        {
            using (var catDb = new CatDb())
            {
                var catListFromDb = catDb.CatProfiles.ToList();
                return View(catListFromDb);
            }
        }

        public ActionResult AddCat()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddCat(CatProfile userCreatedCat)
        {
            if(ModelState.IsValid == false)
            {
                return View(userCreatedCat);
            }
            using (var catDb = new CatDb())
            {
                catDb.CatProfiles.Add(userCreatedCat);
                catDb.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditCat(CatProfile catProfile, HttpPostedFileBase uploadedPicture)
        {
            if (ModelState.IsValid == false)
            {
                return View(catProfile);
            }
            using (var catDb = new CatDb())
            {
                var profilePic = new UploadedFiles.File();
                profilePic.FileName = Path.GetFileName(uploadedPicture.FileName);
                profilePic.ContentType = uploadedPicture.ContentType;

                profilePic.CatProfileIe = catProfile.CatID;
                profilePic.CatProfile = catProfile;

                using (var reader = new BinaryReader(uploadedPicture.InputStream))
                {
                    profilePic.Content = reader.ReadBytes(uploadedPicture.ContentLength);
                }

                catDb.Files.Add(profilePic);

                catProfile.profilePicture = profilePic;
                catDb.Entry(catProfile).State = System.Data.Entity.EntityState.Modified;
                catDb.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult EditCat (int editableCatId)
        {
            using (var catDb = new CatDb())
            {
                var editableCat = catDb.CatProfiles.First(catProfile => catProfile.CatID == editableCatId);
                return View("EditCat", editableCat);
            }
        }

        public ActionResult DeleteCat(int deletableCatId)
        {
            using (var catDb = new CatDb())
            {

                var deletableCat = catDb.CatProfiles.First(CatProfile => CatProfile.CatID == deletableCatId);
                catDb.CatProfiles.Remove(deletableCat);


                catDb.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}