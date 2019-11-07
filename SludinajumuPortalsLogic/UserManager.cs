using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SludinajumuPortals.Logic
{
    
        public class UserManager :BaseManager<User>
        {
            //private int currentId;
            //private static List<User> Users = new List<User>();
            public UserManager(SludinajumuPortalsDB db)
            :base(db)
            {
                //currentId = 1;
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
            return Table.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //public User Create(User user)
        //{
        //    user.Id = currentId;
        //    Users.Add(user);
        //    currentId++;
        //    return user;

        //}
        public User GetByEmail(string email)
        {
            return Table.FirstOrDefault(u => u.Email == email);
        }

        public User GetByUser(int id)
        {
            var getUser = _db.Users.FirstOrDefault(i => i.Id == id);
            return getUser;
        }
            //public void Update(User user)
            //{
            //    var currentUser = Users.Find(u => u.Id == user.Id);
            //    currentUser.Email = user.Email;
            //    currentUser.Password = user.Password;
            //}
            //public void Delete(int id)
            //{
            //    var user = Users.Find(u => u.Id == id);
            //    Users.Remove(user);
            //}

        public void Seed()
            {
                //Users.Add(new User()
                //{
                //    Id = 1,
                //    Email = "Email1",
                //    Password = "Password1"
                //});
                //Users.Add(new User()
                //{
                //    Id = 2,
                //    Email = "Email2",
                //    Password = "Password2"
                //});
            }
        }
    }

