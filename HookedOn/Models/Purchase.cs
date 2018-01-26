using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string AddressLine { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<PurchaseDetail> PurchaseLineItems { get; set; }
        
        public decimal PurchaseTotal { get; set; }

        public DateTime TimeOrderPlaced { get; set; }

    }
}
