using MVCCodeFirst_0.DesignPatterns.SingletonPattern;
using MVCCodeFirst_0.Models.Context;
using MVCCodeFirst_0.Models.Entities;
using MVCCodeFirst_0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst_0.Controllers
{
    public class DirectorController : Controller
    {
        MyContext _db;

        public DirectorController()
        {
            _db = DBTool.DBInstance;
        }
        // GET: Director
        public ActionResult DirectorList()
        {
            DirectorVM dvm = new DirectorVM
            {
                Directors = _db.Directors.ToList()
            };
            return View(dvm);
        }

        public ActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDirector(Director directorInstance)
        {
            _db.Directors.Add(directorInstance);
            _db.SaveChanges();
            return RedirectToAction("DirectorList");
        }

        public ActionResult UpdateDirector(int id)
        {
            DirectorVM dvm = new DirectorVM
            {
                DirectorInstance = _db.Directors.Find(id)
            };
            return View(dvm);
        }

        [HttpPost]
        public ActionResult UpdateDirector(Director directorInstance)
        {
            Director guncellenecek = _db.Directors.Find(directorInstance.ID);
            guncellenecek.FirstName = directorInstance.FirstName;
            guncellenecek.LastName = directorInstance.LastName;
            _db.SaveChanges();
            return RedirectToAction("DirectorList");
        }


        public ActionResult DeleteDirector(int id)
        {
            _db.Directors.Remove(_db.Directors.Find(id));
            _db.SaveChanges();
            return RedirectToAction("DirectorList");
        }
    }
}