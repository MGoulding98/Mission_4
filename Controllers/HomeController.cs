﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext maContext { get; set; }

        public HomeController(MovieApplicationContext x)
        {
            maContext = x;
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
        public IActionResult MovieForm()
        {
            ViewBag.Categories = maContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie m)
        {
            if (ModelState.IsValid)
            {
                maContext.Add(m);
                maContext.SaveChanges();

                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = maContext.Categories.ToList();
                return View(m);
            }
      
        }

        public IActionResult MovieList()
        {
            var movies = maContext.Movies
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = maContext.Categories.ToList();

            var movie = maContext.Movies.Single(x => x.MovieID == movieid);
            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit (Movie m)
        {
            maContext.Update(m);
            maContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

            public IActionResult Delete ()
        {
            return View();
        }
    }
}
