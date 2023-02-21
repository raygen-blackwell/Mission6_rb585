using Film_Collection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext movieContext { get; set; }

        public HomeController(MovieContext mc)
        {
            movieContext = mc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieRatings mr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(mr);
                movieContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View();
            }
            
        }

        public IActionResult MovieList()
        {
            var movieList = movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.MovieTitle)
                .ToList();

            return View(movieList);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            var movieEntry = movieContext.responses.Single(x => x.MovieId == movieid);

            return View("Movies", movieEntry);
        }

        [HttpPost]
        public IActionResult Edit (MovieRatings mr)
        {
            movieContext.Update(mr);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var deleteMovie = movieContext.responses.Single(x => x.MovieId == movieid);

            return View(deleteMovie);
        }

        [HttpPost]
        public IActionResult Delete(MovieRatings mr)
        {
            movieContext.responses.Remove(mr);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
