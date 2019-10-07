using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_error_handling
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            //parbaudes
            //1. Datums nedrikst but nakotne
            if (date > DateTime.Now)
            {
                throw new UserException("Birth date can not be in the future!");
            }

            //2. Datums nedrikst but mazaks par 01.01.1800
            DateTime limit = new DateTime(1800, 1, 1);
            if (date < limit)
            {
                throw new UserException("Birth date can not be less than 01.01.1800");
            }

            //3. Pilnais vards nedrikst parsniegt 20 simbolus
            if (fullName.Length > 20)
            {
                throw new UserException("Full nae too long");
            }

            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            //lietotaja pievienosana
            users.Add(user);

            Console.WriteLine("User with age {0} added!", user.Age());
        }
    }
}
