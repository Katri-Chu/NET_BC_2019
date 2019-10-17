﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class ItemManager
    {
        private int currentId;
        private List<Item> Items;
        public ItemManager()
        {
            Items = new List<Item>();
            currentId = 100;
        }
        public List<Item>GetByCategory(int categoryId)
        {
            var CategoryId = Items.FindAll(u => u.Id == categoryId);
            return CategoryId;
        }
        public Item Create(Item item)
        {
            item.Id = currentId;
            Items.Add(item);
            currentId++;
            return item;
        }
        public void Update(Item item)
        {
            var currentItem = Items.Find(u => u.Id == item.Id);
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;
            currentItem.Description = item.Description;
            currentItem.Photo = item.Photo;
        }
        public void Delete(int id)
        {
            var item = Items.Find(u => u.Id == id);
            Items.Remove(item);
        }
        public Item Get(int id)
        {
            var item = Items.Find(u => u.Id == id);
            return item;
        }
        public void Seed()
        {
            Items.Add(new Item()
            {
                Id = 100,
                Price = 100,
                Title = "Samsung",
                Description = "A5",
                Photo = "www.a5.com",
                Category = 1
            });
            Items.Add(new Item()
            {
                Id = 200,
                Price = 200,
                Title = "iPhone",
                Description = "11",
                Photo = "www.iphone.com",
                Category = 2
            });
        }
    }
}
