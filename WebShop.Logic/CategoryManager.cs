using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        
        public List<Category> Categories;
        
        public CategoryManager()
        {
            Categories = new List<Category>();
        }
        public List<Category>GetAll()
        {
            return Categories;
        }

        public Category Get(int id)
        {
            var category = Categories.Find(u => u.Id == id);
            return category;
        }
        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics",
                
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Clothing",
                
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Mobile",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "TV",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Men's clothing",
                CategoryId = 2
            });
        }
    }
}
