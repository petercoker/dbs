using System;

namespace dbs.ObjectOrientatedProgramming.AbstractClass.Drinks
{
    abstract class Drink
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Drink()
        {

        }

        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //If you create a abstruct the whole thing becomes abstruct also method
        public abstract double GetTax();
    }
}