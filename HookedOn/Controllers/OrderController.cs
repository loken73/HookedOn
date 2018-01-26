using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HookedOn.Interfaces;
using HookedOn.Models;
using Rotativa.NetCore;

namespace HookedOn.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPurchaseRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IPurchaseRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Purchase order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, buy some pets first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete", new { purchaseId = order.PurchaseId });
            }

            return View(order);
        }

        public IActionResult CheckoutComplete(int purchaseId)
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";

            var orderWithDetails = _orderRepository.ShowOrderDetails(purchaseId);

            return View(orderWithDetails);
        }

        /*public IActionResult PDFOrder(int orderId)
        {
            return new ActionAsPdf("CheckoutComplete", new { purchaseId = orderId });
        }*/
    }
}