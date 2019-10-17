using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class UserManager
    {
        private int currentId;
        private List<User> Users;
        public UserManager()
        {
            Users = new List<User>();
            currentId = 1;
        }
        public User GetByEmailAndPassword(string email, string password)
        {
            var getEmailandPassword = Users.Find(u => u.Email == email && u.Password == password);
            return getEmailandPassword;
            
        }

        public User Create(User user)
        {
            user.Id = currentId;
            Users.Add(user);
            currentId++;
            return user;

        }
        public User GetByEmail(string email)
        {
            var getEmail = Users.Find(u => u.Email == email);
            return getEmail;
        }
        public void Delete(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
        public List<User> GetAll()
        {
            return Users;
        }
        public void Update(User user)
        {
            var currentUser = Users.Find(u => u.Id == user.Id);
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
        }
        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "Email1",
                Password = "Password1"
            });
            Users.Add(new User()
            {
                Id = 2,
                Email = "Email2",
                Password = "Password2"
            });
        }
    }
}
