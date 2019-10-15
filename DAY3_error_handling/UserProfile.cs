using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_error_handling
{
    class UserProfile
    {
        public const char MALE = 'M';
        public const char FEMALE = 'F';

        public enum Genders
        {
            Male,
            Female
        }

        public string FullName { get; set; }

        public Genders Gender { get; set; }
        //public char Gender, if no enum

        public DateTime BirthDate { get; set; }

        public UserProfile(string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public int Age()
        {
            //calculate age using BirthDate
            // Save today's date.
            //var today = DateTime.Today;
            // Calculate the age.
            //var age = today.Year - birthdate.Year;
            // Go back to the year the person was born in case of a leap year
            // if (birthdate.Date > today.AddYears(-age)) age--;
            return 1;
        }
    }
}
