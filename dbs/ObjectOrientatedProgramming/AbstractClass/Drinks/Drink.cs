using System;

namespace dbs.ObjectOrientatedProgramming.AbstractClass.Drinks
{
    abstract class Drink
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Drink()
        { }

        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //abstract method, this makes the whole class an abstract one
        //Abstract classes cannot be instantiated/cannot create an 
        //instance of them. All subclasses must enforce/implement the
        //abstract method

        public abstract double GetTax();
        //If you create a abstruct the whole thing becomes abstruct also method

    }
}