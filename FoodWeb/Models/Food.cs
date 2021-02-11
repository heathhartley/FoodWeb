using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWeb.Models
{
    public class Food
    {
        public Food(int rank)
        {
            Rank = rank;
        }
        public int? Rank { get; set; } = 999;
        public string RestuarantName { get; set; } = "Name";

        public string FavoriteDish { get; set; } = "It's all tasty";
        public string Address { get; set; } = "online?";
        public string PhoneNum { get; set; } = "....";

        public string Link { get; set; } = "Coming soon";

        public static Food[] GetRestuarants()
        {
            Food f1 = new Food(1)
            {
                
                RestuarantName = "Taco Bell",
                FavoriteDish = "the Dollar Menu",
                Address = "484 W Bulldog Blvd, Provo, UT 84604",
                PhoneNum = "541-121-2345",
                Link = "https://www.tacobell.com/",
            };
            
            Food f2 = new Food(2)
            {
                Rank = 2,
                RestuarantName = "Chick-Fil-A",
                FavoriteDish = "their Chicken",
                Address = "484 W Bulldog Blvd, Provo, UT",
                PhoneNum = "(801) 374-2697",
                Link = "https://www.chick-fil-a.com/",
            };
            Food f3 = new Food(3)
            {
                
                RestuarantName = "Buffalo Wild Wings",
                FavoriteDish = "their hot buffalo wings",
                Address = "92 N 1200 E, LEHI, UT",
                PhoneNum = "801-766-8402",
                Link = "https://www.buffalowildwings.com",
            };
            Food f4 = new Food(4)
            {
                
                RestuarantName = "Texas Road House",
                FavoriteDish = "their steak",
                Address = "1265 S. State Street, Orem, UT 84097",
                PhoneNum = "801-226-2742",
                Link = "https://www.texasroadhouse.com",
            };
            Food f5 = new Food(5)
            {
                
                RestuarantName = "McDonalds",
                FavoriteDish = "the 1 Dollar Drink",
                Address = "1225 S University Ave",
                PhoneNum = "(801) 373-0370",
                Link = "https://www.mcdonalds.com/us/en-us.html",
            };

            Food f6 = new Food(6)
            {
              
                
                
            };




            return new Food[] { f1, f2, f3, f4, f5, f6};
        }
    }
}
