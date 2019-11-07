using Microsoft.EntityFrameworkCore;
using SludinajumuPortals.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SludinajumuPortals.Logic
{
    public class AdManager : BaseManager<Ad>
    {
        //private int currentId;
        //private List<Ad> Ads;
        public AdManager(SludinajumuPortalsDB db)
            :base(db)
        {
            //Ads = new List<Ad>();
            //currentId = 100;
        }
        protected override DbSet<Ad> Table
        {
            get
            {
                return _db.Ads;
            }
        }
        public List<Ad> GetByCategory(int categoryId)
        {
            var items = _db.Ads.Where(u => u.CategoryId == categoryId).ToList();
            return items;
        }

        public Ad GetWithCategory(int id)
        {
            // ar vienu JOIN pieprasījumu atlasa gan sludinājumu, gan kategoriju
            var data = Table
                .Where(a => a.Id == id)
                .Join(_db.Categories, a => a.CategoryId, c => c.Id, (a, c) => new { Ad = a, Category = c }).FirstOrDefault();

            data.Ad.Category = data.Category;

            return data.Ad;
        }
        public List<Ad> GetByUser(string email)
        {
            return Table.Where(a => a.Email == email).ToList();
        }
        //public Ad Create(Ad item)
        //{
        //    item.CreatedOn = DateTime.Now;
        //    item.Id = currentId;
        //    Ads.Add(item);
        //    currentId++;
        //    return item;
        //}
        //public void Update(Ad item)
        //{
        //    var currentItem = Ads.Find(u => u.Id == item.Id);
        //    currentItem.Price = item.Price;
        //    currentItem.Title = item.Title;
        //    currentItem.Description = item.Description;
        //    currentItem.Photo = item.Photo;
        //    currentItem.CategoryId = item.CategoryId;
        //    currentItem.Email = item.Email;
        //    currentItem.Location = item.Location;
        //    currentItem.Telephone = item.Telephone;
        //}
        //public void Delete(int id)
        //{
        //    var item = Ads.Find(u => u.Id == id);
        //    Ads.Remove(item);
        //}
        //public Ad Get(int id)
        //{
        //    var item = Ads.Find(u => u.Id == id);
        //    return item;
        //}
        public void Seed()
        {
            //Ads.Add(new Ad()
            //{
            //    Id = 100,
            //    CategoryId = 3,
            //    Price = 100,
            //    Title = "Title1",
            //    Description = "Description1",
            //    Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRE9-LwCqPE5HabQk3FcXaMjQPWRUJHzw0Xw3OAyg0jatBbYBgw",
            //    CreatedOn = DateTime.Now,
            //    Email = "name1@mail.com",
            //    Location = "Location1",
            //    Telephone = "29323232"
            //});
            //Ads.Add(new Ad()
            //{
            //    Id = 200,
            //    CategoryId = 4,
            //    Price = 200,
            //    Title = "Title2",
            //    Description = "Description2",
            //    Photo = "https://images.pexels.com/photos/207962/pexels-photo-207962.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            //    CreatedOn = DateTime.Now,
            //    Email = "name2@mail.com",
            //    Location = "Location2",
            //    Telephone = "293454384"
            //});
            //Ads.Add(new Ad()
            //{
            //    Id = 300,
            //    CategoryId = 5,
            //    Price = 600,
            //    Title = "Title3",
            //    Description = "Description3",
            //    Photo = "https://images.pexels.com/photos/207962/pexels-photo-207962.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            //    CreatedOn = DateTime.Now,
            //    Email = "name3@mail.com",
            //    Location = "Location3",
            //    Telephone = "2934348794"
            //});
            //Ads.Add(new Ad()
            //{
            //    Id = 400,
            //    CategoryId = 7,
            //    Price = 1000,
            //    Title = "Title4",
            //    Description = "Description4",
            //    Photo = "https://images.pexels.com/photos/207962/pexels-photo-207962.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            //    CreatedOn = DateTime.Now,
            //    Email = "name4@mail.com",
            //    Location = "Location4",
            //    Telephone = "2934897594"
            //});
        }
    }
}
