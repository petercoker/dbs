using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.FoodInterfaceExample
{
    class Apple : Food, IEdible
    {
        public string AnimalType { get; set; }
        public Apple(ColourEnum colour, double weight, string type)
            :base(colour, weight)
        {
            AnimalType = type;
        }

        //implementation of the IEdible methods
        public string Taste()
        {
            return "It tasted like an apple";
        }

        public string Prepare()
        {
            return "Pick it from tree";
        }

        //Add Main()
        //Apple apple = new Apple(ColourEnum.Red, 0.5, "Fruit");

        //Console.WriteLine(apple);
        //Console.WriteLine(apple.Taste());
        //Console.WriteLine(apple.Prepare());

    }
}
