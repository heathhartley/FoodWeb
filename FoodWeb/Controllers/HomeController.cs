using FoodWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<string> FoodList = new List<string>();

            foreach (Food f in Food.GetRestuarants())
            {
                FoodList.Add($"#{f.Rank}: {f.RestuarantName} is located at {f.Address}. Their famous dish is {f.FavoriteDish}. Check out their website: {f.Link} or give them a call at {f.PhoneNum}");
            }

            return View(FoodList);
        }

        

          


        [HttpGet]
        public IActionResult EnterSuggestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterSuggestion(AddResturant resturant)
        {
            if(ModelState.IsValid)
            {
                tempstorage.AddResturant(resturant);
                return View("Conformation", resturant);
            }

            return View();
        }

        public IActionResult ListofSuggestions()
        {
            return View(tempstorage.EnterResturant);
        }

        public IActionResult Conformation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
