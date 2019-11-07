using Microsoft.EntityFrameworkCore;
using SludinajumuPortals.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SludinajumuPortals.Logic
{
    public class CategoryManager : BaseManager<Category>
    {

        

        public CategoryManager(SludinajumuPortalsDB db)
            : base(db)
        {
            //Categories = new List<Category>();
        }

        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }
        public List<Category> GetAllWithAdCount()
        {
            var categories = Table.ToList();
            categories.ForEach(c =>
            {
                c.AdCount = _db.Ads.Count(a => a.CategoryId == c.Id);
            });
            return categories;
        }
        //public List<Category> GetAll()
        //{
        //    return Categories;
        //}

        //public Category Get(int id)
        //{
        //    var category = Categories.Find(u => u.Id == id);
        //    return category;
        //}
        public void Seed()
        {
            //Categories.Add(new Category()
            //{
            //    Id = 1,
            //    Title = "Sieviešu apģērbi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 9,
            //    Title = "Virsdrēbes",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 10,
            //    Title = "Krekli",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 11,
            //    Title = "Bikses",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 12,
            //    Title = "Apakšveļa",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 2,
            //    Title = "Vīriešu apģērbi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 13,
            //    Title = "Virsdrēbes",
            //    CategoryId = 2
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 14,
            //    Title = "Krekli",
            //    CategoryId = 2
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 15,
            //    Title = "Bikses",
            //    CategoryId = 2
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 16,
            //    Title = "Apakšveļa",
            //    CategoryId = 2
            //});

            //Categories.Add(new Category()
            //{
            //    Id = 5,
            //    Title = "Apavi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 17,
            //    Title = "Papēžkurpes",
            //    CategoryId = 5
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 18,
            //    Title = "Zābaki",
            //    CategoryId = 5
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 19,
            //    Title = "Zandales",
            //    CategoryId = 5
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 20,
            //    Title = "Mokasīni",
            //    CategoryId = 5
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 3,
            //    Title = "Bērnu apģērbi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 21,
            //    Title = "Virsdrēbes",
            //    CategoryId = 3
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 22,
            //    Title = "Krekliņi",
            //    CategoryId = 3
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 23,
            //    Title = "Bikses",
            //    CategoryId = 3
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 24,
            //    Title = "Apakšveļa",
            //    CategoryId = 3
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 8,
            //    Title = "Īpašie piedāvājumi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 37,
            //    Title = "Helovīns",
            //    CategoryId = 8
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 38,
            //    Title = "3 par 2 cenu",
            //    CategoryId = 8
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 39,
            //    Title = "Dāvanu iesaiņošana",
            //    CategoryId = 8
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 7,
            //    Title = "Aksesuāri",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 33,
            //    Title = "Vīriešu",
            //    CategoryId = 7
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 34,
            //    Title = "Sieviešu",
            //    CategoryId = 7
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 35,
            //    Title = "Bērnu",
            //    CategoryId = 7
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 36,
            //    Title = "Dažādi",
            //    CategoryId = 7
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 6,
            //    Title = "Smaržas",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 29,
            //    Title = "Sieviešu",
            //    CategoryId = 6
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 30,
            //    Title = "Vīriešu",
            //    CategoryId = 6
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 31,
            //    Title = "Uniseks",
            //    CategoryId = 6
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 32,
            //    Title = "Jaunumi",
            //    CategoryId = 6
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 4,
            //    Title = "Sporta apģērbi",

            //});
            //Categories.Add(new Category()
            //{
            //    Id = 25,
            //    Title = "Augšas",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 26,
            //    Title = "Apakšas",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 27,
            //    Title = "Botas",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 28,
            //    Title = "Sporta aksesuāri",
            //    CategoryId = 4
            //});

            
        }
    }
}
