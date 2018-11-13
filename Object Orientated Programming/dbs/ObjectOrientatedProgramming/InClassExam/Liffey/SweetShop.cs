using System;
using System.Collections.Generic;
using System.Text;

namespace dbs.ObjectOrientatedProgramming.InClassExam.Liffey
{
    class SweetShop : Shop, ICustomer
    {
        public int NumberOfStaff { get; set; }
        public string CustomerName { get; set; }

        public SweetShop()
        {

        }

        public SweetShop(string name, string owner, int numberOfStaff)
            : base(name, owner)
        {
            NumberOfStaff = numberOfStaff;
        }

        public string GreetCustomer()
        {
            return "\nWelcome to the sweet shop";
        }

        public string ServeCustomer()
        {
            return "\nWhat type of sweet can I get you";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nOwner: {Owner}\nNumber of Staff: {NumberOfStaff}";
        }
    }
}
