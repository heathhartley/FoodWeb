using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWeb.Models
{
    public class tempstorage
    {
        private static List<AddResturant> resturants = new List<AddResturant>();

        public static IEnumerable<AddResturant> EnterResturant => resturants;

        public static void AddResturant(AddResturant rest)
        {
            resturants.Add(rest);
        }
    }
}
