using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustommerService
{
    public class Custommer
    {
        public Custommer(int iD, string firstName, string lastName, string email, string gender, string country, string city, string phone, double price, DateTime birthday)
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

        [DataFormat("0")]
        public  int ID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string Gender { get; set; }
        public  string Country { get; set; }
        public  string City { get; set; }
        public  string Phone { get; set; }

        [DataFormat("0.00")]
        public  double Price { get; set; }
        public  DateTime Birthday { get; set; }
    }
}
