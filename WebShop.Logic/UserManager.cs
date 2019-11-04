using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class UserManager : BaseManager<User>
    {
        //WebShopDB _db;
        public UserManager(WebShopDB db)
            :base(db)
        {
            //_db = db;
        }
        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }
        }
        public User GetByEmailAndPassword(string email, string password)
        {
            var getEmailandPassword = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return getEmailandPassword;
            
        }
        //public User Create(User user)
        //{
        //    _db.Users.Add(user);
        //    return user;
        //}
        public User GetByEmail(string email)
        {
            var getEmail = _db.Users.FirstOrDefault(u => u.Email == email);
            return getEmail;
        }
        //public void Delete(int id)
        //{
        //    var user = _db.Users.FirstOrDefault(u => u.Id == id);
        //    _db.Users.Remove(user);
        //    _db.SaveChanges();
        //}
        //public void Update(User user)
        //{
        //    var currentUser = _db.Users.FirstOrDefault(u => u.Id == user.Id);
        //    _db.SaveChanges();
        //}
        public void Seed()
        {
           
        }
    }
}
