using Microsoft.AspNetCore.Mvc;
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
        private MovieApplicationContext _MovieContext { get; set; }

        public HomeController(MovieApplicationContext x)
        {
            _MovieContext = x;
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
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieModel m)
        {
            _MovieContext.Add(m);
            _MovieContext.SaveChanges();

            return View("Confirmation");
        }
    }
}
