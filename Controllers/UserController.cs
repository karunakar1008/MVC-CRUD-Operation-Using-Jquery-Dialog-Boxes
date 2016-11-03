using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery_CRUD.DAL;

namespace jQuery_CRUD.Controllers
{
    public class UserController : Controller
    {
        private DataContext db = new DataContext();

        

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        

        public ActionResult Details(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return PartialView(user);
        }


        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user, string Command)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                TempData["Msg"] = "Data has been saved succeessfully";
                return RedirectToAction("Index");
            }

            return PartialView(user);
        }

  
        public ActionResult Edit(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return PartialView(user);
        }

   

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Msg"] = "Data has been updated succeessfully";
                return RedirectToAction("Index");

            }
            return PartialView(user);
        }


        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            TempData["Msg"] = "Data has been deleted succeessfully";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}