using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateUser()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "new email",
                Password = "new password"
            });

            Assert.AreEqual("new email", user.Email);
            Assert.AreEqual("new password", user.Password);
            Assert.IsTrue(user.Id > 0);
        }
        [TestMethod]
        public void TestGetUserbyEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();
            User user1 = manager.GetByEmailAndPassword(email: "Email1", password: "Password1");
            User user2 = manager.GetByEmailAndPassword(email: "Email2", password: "Password2");
            User user3 = manager.GetByEmailAndPassword(email: "Email3", password: "Password3");

            Assert.AreEqual("Email1", user1.Email);
            Assert.AreEqual("Password1", user1.Password);
            Assert.AreEqual("Email2", user2.Email);
            Assert.AreEqual("Password2", user2.Password);
            Assert.AreNotEqual("Passwrod4", user2.Password);
            Assert.AreNotEqual("Email4", user2.Password);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestUpdateUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Update(new User()
            {
                Id = 2,
                Email = "new name",
                Password = "new password"
            });

            var user = manager.GetByEmailAndPassword(email: "new name", password: "new password");


            Assert.AreEqual("new name", user.Email);
            Assert.AreEqual("new password", user.Password);
        }
        [TestMethod]
        public void TestDeleteUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);
            var allUsers = manager.GetAll();
            var deletedUser = manager.GetByEmailAndPassword(email: "Email1", password: "Password1");

            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deletedUser);
        }
        [TestMethod]
        public void TestCreateItem()
        {
            ItemManager manager = new ItemManager();
            Item item = manager.Create(new Item()
            {
                Price = 300,
                Title = "new title",
                Description = "new description",
                Photo = "new photo"
            });
            Assert.AreEqual(300, item.Price);
            Assert.AreEqual("new title", item.Title);
            Assert.AreEqual("new description", item.Description);
            Assert.AreEqual("new photo", item.Photo);
            Assert.IsTrue(item.Id > 0);
        }
        [TestMethod]
        public void TestUpdateItem()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            manager.Update(new Item()
            {
                Id = 200,
                Price = 300,
                Title = "new title",
                Description = "new description",
                Photo = "new photo"
            });

            var item = manager.Get(200);
            Assert.AreEqual(200, item.Id);
            Assert.AreEqual(300, item.Price);
            Assert.AreEqual("new title", item.Title);
            Assert.AreEqual("new description", item.Description);
            Assert.AreEqual("new photo", item.Photo);
        }
        [TestMethod]
        public void TestDeleteItem()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            manager.Delete(100);

            var deletedItem = manager.Get(100);

            Assert.IsNull(deletedItem);
        }

        //[TestMethod]
        //public void TestGetItem()
        //{
        //    ItemManager manager = new ItemManager();
        //    manager.Seed();

        //}
        //List<Item> GetByCategory(int categoryId) 
        //    (izsaukt ar esošu kategoriju, pārbaudam skaitu.Pārbaudam piem ar 5, un atgriež 0)
        //List<Category>GetAll() (atgriezž skaitu)

        [TestMethod]
        public void TestGetItemByCategory()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
            var result = manager.GetByCategory(100);
            var result2 = manager.GetByCategory(300);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(0, result2.Count);

        }
        [TestMethod]
        public void TestCategoryGetAll()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();
            var result = manager.GetAll();

            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void TestCategoryGet()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();
            Category category1 = manager.Get(1);
            Category category2 = manager.Get(2);
            Category category3 = manager.Get(3);

            Assert.AreEqual("Name 1", category1.Title);
            Assert.AreEqual("Name 2", category2.Title);
            Assert.IsNull(category3);
        }
    }
}
