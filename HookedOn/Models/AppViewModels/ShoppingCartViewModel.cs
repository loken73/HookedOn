using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models.AppViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart CurrentCart { get; set; }

        public decimal CurrentCartTotal { get; set; }
    }
}
