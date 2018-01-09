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
                var catListFromDb = catDb.CatProfiles.Include(CatProfile => CatProfile.profilePicture).ToList();
                return View(catListFromDb);
            }
        }

        public ActionResult AddCat()
        {

            return View();
        }
        
        


        [HttpPost]
        public ActionResult AddCat(CatProfile userCreatedCat, HttpPostedFileBase uploadedPicture)
        {
            if (ModelState.IsValid == false)
            {
                return View(userCreatedCat);
            }

            using (var catDb = new CatDb())
            {
                catDb.CatProfiles.Add(userCreatedCat);
                
                catDb.SaveChanges();
                
                if (uploadedPicture != null)
                {
                   var profilePic = new UploadedFiles.File();
                    
                    profilePic.FileName = Path.GetFileName(uploadedPicture.FileName);
                    
                    profilePic.ContentType = uploadedPicture.ContentType;

                    using (var reader = new BinaryReader(uploadedPicture.InputStream))
                    {
                        profilePic.Content = reader.ReadBytes(uploadedPicture.ContentLength);
                    }
                    
                    profilePic.CatProfileIe = userCreatedCat.CatID;
                    profilePic.CatProfile = userCreatedCat;
                    
                    catDb.Files.Add(profilePic);
                    catDb.SaveChanges();
                    
                    userCreatedCat.profilePicture = profilePic;
                    
                    catDb.SaveChanges();
                }
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
                if (uploadedPicture != null)
                {
                    var currentPic = catDb.Files.FirstOrDefault(fileRecord => fileRecord.CatProfileIe == catProfile.CatID);
                    if(currentPic != null)
                    {
                        catDb.Files.Remove(currentPic);
                    }
                    
                        
                    

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
                }
                    catDb.Entry(catProfile).State = System.Data.Entity.EntityState.Modified;
                    catDb.SaveChanges();
                
            }

            return RedirectToAction("Index");
        }

        public ActionResult EditCat (int editableCatId)
        {
            using (var catDb = new CatDb())
            {
                var editableCat = catDb.CatProfiles.Include(catRecord => catRecord.profilePicture).First(catProfile => catProfile.CatID == editableCatId);
                return View("EditCat", editableCat);
            }
        }

        public ActionResult DeleteCat(int deletableCatId)
        {
            using (var catDb = new CatDb())
            {

                var deletableCat = catDb.CatProfiles.Include(catProf => catProf.profilePicture).First(record => record.CatID == deletableCatId);
                if (deletableCat.profilePicture != null)
                {
                       catDb.Files.Remove(deletableCat.profilePicture);
                }
                catDb.CatProfiles.Remove(deletableCat);


               catDb.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        public ActionResult GetCatProfilePicture(int catProfilePictureId)
        {
            using (var db = new CatDb())
            {
                var profilePic = db.Files.First(rec => rec.FileId == catProfilePictureId);
                return File(profilePic.Content, profilePic.ContentType);
            } 
                    
        }
            
       

        
    }
}