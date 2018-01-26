using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models
{
    public abstract class Animal
    {
        public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Temperament { get; set; }

        [Display(Name = "Expected Level of Care")]
        public string CareLevel { get; set; }

        [Display(Name = "Life Expectancy")]
        public string LifeExpectancy { get; set; }

        public string Origin { get; set; }

        [Display(Name = "Size as Adult")]
        public string AdultSize { get; set; }

        public string Diet { get; set; }

        [Display(Name ="Optimum Ambient Temperature")]
        public string AmbientTemperature { get; set; }

        public decimal Price { get; set; }

        public DateTime DateAdded { get; set; }

        public string ImageUrl { get; set; }

    }
}
