﻿using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Domain.Entities
{
    public class ShippingDetails

    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line ")]
        [Display(Name = "Line 1")]
        public string Line1 { get; set; }
        [Display(Name = "Line 2")]
        public string Line2 { get; set; }
        [Display(Name = "Line 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Display(Name = "County")]
        [Required(ErrorMessage = "Please enter a County name")]
        public string County { get; set; }
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Please enter a Country name")]
        //public string Country { get; set; }
        public bool GiftWrap { get; set; }

    }

}
