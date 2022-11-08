using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Custommer
    {
        public Custommer(int iD, string firstName, string lastName, string email, string gender, string country, string city, string phone, string price, DateTime birthday)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Country = country;
            City = city;
            Phone = phone;
            Price = price;
            Birthday = birthday;
        }

        public  int ID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string Gender { get; set; }
        public  string Country { get; set; }
        public  string City { get; set; }
        public  string Phone { get; set; }
        public  string Price { get; set; }
        public  DateTime Birthday { get; set; }
    }
}
