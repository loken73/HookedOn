using System.ComponentModel.DataAnnotations;

namespace HookedOn.Models
{
    public class Fish : Animal
    {
        [Display(Name = "Minimum tank size")]
        public string AquariumSize { get; set; }

        [Display(Name = "Type of Water")]
        public string WaterType { get; set; }

        [Display(Name = "Reef Safe")]
        public string ReefSafe { get; set; }

    }
}
