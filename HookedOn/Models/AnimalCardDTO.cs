using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models
{
    public class AnimalCardDTO
    {
        public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Temperament { get; set; }

        public string CareLevel { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
