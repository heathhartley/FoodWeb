using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWeb.Models
{
    public class AddResturant
    {
        #nullable enable
        public string? Restuarant { get; set; } = "No Name";
        #nullable disable
        public string Favorite { get; set; } = "It’s all tasty!";

        public string Address { get; set; } = "online?";
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        public string Link { get; set; } = "coming soon!";


    }
}
