using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class ItemManager : BaseManager<Item>
    {
        //WebShopDB _db;
        
        public ItemManager(WebShopDB db)
            :base(db)
        {
            //_db = db;
        }

        protected override DbSet<Item> Table
        {
            get
            {
                return _db.Items;
            }
        }
        public List<Item>GetByCategory(int categoryId)
        {
            var items = _db.Items
                .Where(u => u.Category == categoryId)
                .ToList();
            return items;
        }
        //public Item Create(Item item) //viss realizēts basemanager
        //{
        //    _db.Items.Add(item);
        //    _db.SaveChanges();
        //    return item;
        //}
        //public void Update(Item item)
        //{
        //    var currentItem = _db.Items.FirstOrDefault(u => u.Id == item.Id);
        //    currentItem.Price = item.Price;
        //    currentItem.Title = item.Title;
        //    currentItem.Description = item.Description;
        //    currentItem.Photo = item.Photo;

        //    _db.SaveChanges();
        //}
        //public void Delete(int id)
        //{
        //    var item = _db.Items.FirstOrDefault(u => u.Id == id);
        //    _db.Items.Remove(item);

        //    _db.SaveChanges();
        //}
        //public Item Get(int id)
        //{
        //    var item = _db.Items.FirstOrDefault(u => u.Id == id);
        //    return item;
        //}
        public void Seed()
        {
            
        }
    }
}
