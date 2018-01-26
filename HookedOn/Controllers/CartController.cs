using HookedOn.Interfaces;
using HookedOn.Models;
using HookedOn.Models.AppViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Controllers
{
    public class CartController : Controller
    {
        private readonly IAnimalRepository _animalRepo;
        private readonly ShoppingCart _shoppingCart;

        public CartController(IAnimalRepository animalRepo, ShoppingCart shoppingCart)
        {
            _animalRepo = animalRepo;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                CurrentCart = _shoppingCart,
                CurrentCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

     
        public RedirectToActionResult AddToShoppingCart(int animalId)
        {
            var selectedAnimal = _animalRepo.GetAnimalById(animalId);
            if (selectedAnimal != null)
            {
                _shoppingCart.AddToCart(selectedAnimal, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int animalId)
        {
            var selectedAnimal = _animalRepo.GetAnimalById(animalId);
            if (selectedAnimal != null)
            {
                _shoppingCart.RemoveFromCart(selectedAnimal);
            }
            return RedirectToAction("Index");
        }
    }
}
