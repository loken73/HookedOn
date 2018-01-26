using HookedOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Interfaces
{
    public interface IPurchaseRepository
    {
        void CreateOrder(Purchase purchase);

        Purchase ShowOrderDetails(int purchaseId);
    }
}
