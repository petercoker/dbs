using System;

namespace dbs.ObjectOrientatedProgramming.AbstractClass.Drinks
{
    class Alcohol : Drink
    {
        public double AlcholContent { get; set; }

        public Alcohol()
        {

        }

        public override string ToString()
        {
            return "This is the alcohol Class";
        }

        public override double GetTax()
        {
            return Price + (Price * .12);
        }

        //Add to Main()

        //SoftDrink cola = new SoftDrink();

        //Console.WriteLine("What is the name of the drink");
        //cola.Name = Console.ReadLine();
        //Console.WriteLine("What is the price");
        //cola.Price = double.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter the colour");
        //cola.Colour = Console.ReadLine();
        
        //Console.WriteLine(cola.ToString());
        //Console.WriteLine($"{cola.Name} costs {cola.Price}. The " + $"Tax is {cola.GetTax()}");




    }

}