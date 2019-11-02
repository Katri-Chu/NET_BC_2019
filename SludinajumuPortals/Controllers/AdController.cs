using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SludinajumuPortals.Logic;
using SludinajumuPortals.Models;

namespace SludinajumuPortals.Controllers
{
    public class AdController : Controller
    {
        
            AdManager manager = new AdManager();

            public AdController()
            {
                manager.Seed();
            }

            public IActionResult Index(int id)
            {
                var ads = manager.GetByCategory(id);

                return View(ads);
            }

            public IActionResult View(int id)
            {
                var ad = manager.Get(id);

                return View(ad);
            }

            public IActionResult Create() //get funkcijai iekavās nekas nav nepieciešams
            {
            AdModel model = new AdModel();
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Seed();
            model.Email = HttpContext.Session.GetUserEmail();
            model.Categories = categoryManager.GetAll();
            

                return View(model);
            }
        [HttpPost] //post metodei ir nepieciešams norādīt iekavās, ko izsauc
        public IActionResult Create(AdModel model) //nosauc vienādi, jo atbilst vienam cshtml failam 
        {
            if(ModelState.IsValid)
            {
                //TODO: ieraksta saglabāšana

            }
            return View(model);
        }
       
    }
}