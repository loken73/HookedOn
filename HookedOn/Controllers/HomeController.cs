using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HookedOn.Models;
using HookedOn.Repositories;
using HookedOn.Interfaces;

namespace HookedOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimalRepository _animalRepo;

        public HomeController(IAnimalRepository animalRepo)
        {
            _animalRepo = animalRepo;
        }

        public IActionResult Index()
        {
            var FourNewestAnimals = _animalRepo.GetNewestAnimals;
        
            return View(FourNewestAnimals);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
