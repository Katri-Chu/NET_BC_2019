using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SludinajumuPortals.Models;
using SludinajumuPortals.Logic;

namespace SludinajumuPortals.Controllers
{
    public class HomeController : Controller
    {
        
            private CategoryManager manager = new CategoryManager();
            
            public HomeController()
            {
                manager.Seed();
            }

        public IActionResult Index()
        {
            var categories = manager.GetAll();

            return View(categories);
        }
        

        public IActionResult Privacy()
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
