using CatDatingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            using (var db = new CatDb())
            {
                var blogsList = db.Blog.ToList();
                return View(blogsList);
            }
        }

        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog userCreatedBlog)
        {
            using (var blogDb = new CatDb())
            {
                blogDb.Blog.Add(userCreatedBlog);
                userCreatedBlog.BlogCreated = DateTime.Now;
                userCreatedBlog.BlogModified = DateTime.Now;


                blogDb.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        
        
        public ActionResult EditBlog(int editBlog)
         
        {
            
            using (var blogDb = new CatDb())
            {
                var editableBlog = blogDb.Blog.First(record => record.BlogID == editBlog);
                return View("EditBlog", editableBlog);
                         
            }
           
        }


        [HttpPost]
        public ActionResult EditBlog(Blog editBlog)
        {
            if (ModelState.IsValid == false)
            {
                return View(editBlog);
            }
            using (var blogDb = new CatDb())
            {
                blogDb.Entry(editBlog).State = System.Data.Entity.EntityState.Modified;
                editBlog.BlogModified = DateTime.Now;
                blogDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }



        public ActionResult DeleteBlog(int deleteBlog)
        {
            using (var blogDb = new CatDb())
            {

                var deletableBlog = blogDb.Blog.First(record => record.BlogID == deleteBlog);

                blogDb.Blog.Remove(deletableBlog);
                
                blogDb.SaveChanges();
            }

            return RedirectToAction("Index");

        }

    }        


   
}