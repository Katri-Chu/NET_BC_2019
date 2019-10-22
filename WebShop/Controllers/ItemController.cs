using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            var manager = new ItemManager();
            manager.Seed();
            var items = manager.GetByCategory(id);
            var manager1 = new CategoryManager();
            manager1.Seed();
            var category = manager1.GetAll();
            
            var model = new CatalogModel()
            {
                Items = items,
                Categories = category,
                
            };
            

            return View(model);
        }
    }
}