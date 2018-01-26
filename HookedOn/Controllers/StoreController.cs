using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HookedOn.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HookedOn.Controllers
{
    public class StoreController : Controller
    {
        private readonly IAnimalRepository _animalRepo;
        private readonly IModelMetadataProvider _provider;

        public StoreController(IAnimalRepository animalRepo, IModelMetadataProvider provider)
        {
            _animalRepo = animalRepo;
            _provider = provider;
        }

        public IActionResult Index()
        {
            var allAnimals = _animalRepo.GetAllAnimals;

            return View(allAnimals);
        }

        public IActionResult Fish()
        {
            var fishOnly = _animalRepo.GetFish;


            return View(fishOnly);
        }

        public IActionResult Mammals()
        {
            var mammalsOnly = _animalRepo.GetMammals;

            return View(mammalsOnly);
        }

        public IActionResult Reptiles()
        {
            var reptilesOnly = _animalRepo.GetReptiles;

            return View(reptilesOnly);
        }

        public IActionResult IndividualAnimal (string animalName)
        {
            var individualAnimal = _animalRepo.GetAnimalByName(animalName);

            return View(individualAnimal);
        }
    }
}