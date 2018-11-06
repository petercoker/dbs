using System;
using System.Collections.Generic;
using System.Text;

namespace dbs.ObjectOrientatedProgramming.InClassExam.Liffey
{
    class Restaurant : Shop, ICustomer
    {
        public int NumberOfTables { get; set; }
        public string CustomerName { get; set; }
        public RatingEnum Rating { get; set; }

        public Restaurant()
        {

        }

        public Restaurant(string name, string owner, int numberOfTables, RatingEnum rating)
            : base(name, owner)
        {
            NumberOfTables = numberOfTables;
            Rating = rating;
        }

        public string GreetCustomer()
        {
            return "Welcome to the resturant";
        }

        public string ServeCustomer()
        {
            return "What type of meal can I get you";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nOwner: {Owner}\nNumber of Staff: {Rating}";
        }
    }
}
