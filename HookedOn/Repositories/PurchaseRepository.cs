using HookedOn.Data;
using HookedOn.Interfaces;
using HookedOn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public PurchaseRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Purchase purchase)
        {
            purchase.TimeOrderPlaced = DateTime.Now;

            _appDbContext.Purchases.Add(purchase);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new PurchaseDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    AnimalId = shoppingCartItem.Animal.AnimalId,
                    Animal = shoppingCartItem.Animal,
                    PurchaseId = purchase.PurchaseId,
                    Price = shoppingCartItem.Animal.Price
                };

                _appDbContext.PurchaseDetails.Add(orderDetail);
            }

            purchase.PurchaseTotal = _shoppingCart.GetShoppingCartTotal();

            _appDbContext.SaveChanges();
        }

        public Purchase ShowOrderDetails (int purchaseId)
        {
            var orderWithDetails = new Purchase();

            orderWithDetails = _appDbContext.Purchases
                               .Include(pd => pd.PurchaseLineItems)
                               .ThenInclude(detail => detail.Animal)
                               .Where(o => o.PurchaseId == purchaseId)
                               .FirstOrDefault();

            return (orderWithDetails);
        }
    }
}
