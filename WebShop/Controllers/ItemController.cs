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
           // var categories = CategoryManager.GetAll(); <pabeigt mājās
            //foreach(var cat in categories)
            //{
            //    //... atlasa un uzstāda skaitu zem konkrētās kategorijas
            //}
            
            var model = new CatalogModel()
            {
                Items = items,
                Categories = category,
                
            };
            return View(model);
        }

        // 1. Pievieno jaunu darbību Buy ar vienu parametru - id
        // 2. Atlasa lietotāja grozu no sesijas:
        // 2.1. Ja grozs nav definēts, definē jaunu sarakstu (new List<int>())
        // 3. Pievieno izvēlēto preces ID lietotāja grozam;
        // 4. Saglabā lietotāja grozu sesijā.
        public IActionResult Buy(int id, int categoryId)
        {
            var manager = new ItemManager();
            manager.Seed();
            var item = manager.Get(id);

            var basket = HttpContext.Session.GetUserBasket();
            if(basket == null)
            {
                basket = new List<int>();
                
            }
            basket.Add(id);
            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Index", "Item", new {id = categoryId }); //var uzskatīt vairākus parametrus
        }

        public IActionResult Basket()
        {
            // 1. Definē jaunu sarakstu ar precēm
            // 2. Par katru preci, kas ir lietotāja sesijā atlasa tās datus un pievieno sarakstam; (item manager)
            // 3. Atgriež preču sarakstu uz View
            var items = new List<Item>();
            var basket = HttpContext.Session.GetUserBasket();
            if (basket !=null)
            { 
                var manager = new ItemManager();
                manager.Seed();

                foreach (var id in basket)
                {
                    items.Add(manager.Get(id));
                }
            }
            return View(items);
        }
        public IActionResult Delete(int id)
        {
            
            var basket = HttpContext.Session.GetUserBasket();
            basket.Remove(id);
            HttpContext.Session.SetUserBasket(basket);
            return RedirectToAction("Basket", "Item");
        }
    }
}