using System;

namespace dbs.ObjectOrientatedProgramming.IntroductionToClasses.DrinkExample
{
    class Drink
    {

        //Properties
        public string Name { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }


        //Default constructor. Dont have to 
        //Type it. Its there already
        public Drink()
        {

        }

        //All contrustors must have same name as 
        //The class itself
        public Drink(string name, double size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        //Create a method
        public double GetTotalCost(int amount)
        {
            return Price * amount;
        }

        //Add to main method
        //Create an instance of drink
        //Drink drink1 = new Drink("Orange", 1.5, 2.30);
        //Drink drink2 = new Drink("Cola", 500, 1);

        //Console.WriteLine("The Drink is " + drink1.Name);
        //    Console.WriteLine("The size is " + drink1.Size);
        //    Console.WriteLine("The price is " + drink1.Price);
        //    Console.WriteLine("The total Cost is " + drink1.GetTotalCost(5));

        //    Console.WriteLine("The Drink is " + drink2.Name);
        //    Console.WriteLine("The size is " + drink2.Size);
        //    Console.WriteLine("The price is " + drink2.Price);
        //    Console.WriteLine("The total Cost is " + drink2.GetTotalCost(10));
    }
}
