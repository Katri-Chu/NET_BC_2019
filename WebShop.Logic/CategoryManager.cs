using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        
        private List<Category> Categories;
        
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
                Title = "Name 1",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Name 2",
                CategoryId = 2
            });

        }
    }
}
