using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models
{
    public class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }

        public int PurchaseId { get; set; }

        public int AnimalId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public Purchase Purchase { get; set; }

        public Animal Animal { get; set; }
    }
}
