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
    public class MovieController : Controller
    {
        MyContext _db;
        public MovieController()
        {
            _db = DBTool.DBInstance;
        }


        // GET: Movie
        public ActionResult MovieList()
        {
            MovieVM mvm = new MovieVM
            {
                Movies = _db.Movies.ToList()
            };
            return View(mvm);
        }

        public ActionResult AddMovie()
        {
            MovieVM mvm = new MovieVM
            {
                Directors = _db.Directors.ToList()
            };
            return View(mvm);
        }

        [HttpPost]
        public ActionResult AddMovie(Movie movieInstance)
        {
            _db.Movies.Add(movieInstance);
            _db.SaveChanges();
            return RedirectToAction("MovieList");
        }

        public ActionResult UpdateMovie(int id)
        {
            MovieVM mvm = new MovieVM
            {
                Directors = _db.Directors.ToList(),
                MovieInstance = _db.Movies.Find(id)
            };
            return View(mvm);
        }


        [HttpPost]
        public ActionResult UpdateMovie(Movie movieInstance)
        {
            Movie guncellenecek = _db.Movies.Find(movieInstance.ID);
            guncellenecek.Title = movieInstance.Title;
            guncellenecek.Summary = movieInstance.Summary;
            guncellenecek.DirectorID = movieInstance.DirectorID;
            _db.SaveChanges();
            return RedirectToAction("MovieList");
        }

        public ActionResult DeleteMovie(int id)
        {
          
            

            _db.Movies.Remove(_db.Movies.Find(id));
            _db.SaveChanges();
            return RedirectToAction("MovieList");

        }
    }
}