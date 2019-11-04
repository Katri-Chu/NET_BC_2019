using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class CategoryManager : BaseManager<Category>
    {

        //WebShopDB _db; Viss, kas aizīmēts, bija vajadzīgs, lai viss strādātu bez basemanager klases
        
        public CategoryManager(WebShopDB db)
            :base(db) //padodam tālāk uz basemanageri
        {
            //_db = db;
        }

        // raksta override, izvēlas kuru mainīgo vajag (Table šajā gadījumā), un enter < pats uzģenerē vajadzīgo rindu
        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }

        //jau realizēts baseManager
        //public List<Category>GetAll() j
        //{
        //    return _db.Categories.ToList();
        //}

        //public Category Get(int id)
        //{
        //    var category = _db.Categories.FirstOrDefault(u => u.Id == id);
        //    return category;
        //}
        public void Seed()
        {
           
        }
    }
}
