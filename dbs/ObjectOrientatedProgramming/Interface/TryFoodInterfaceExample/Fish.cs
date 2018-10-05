using System;

namespace dbs.ObjectOrientatedProgramming.Interface.TryFoodInterfaceExample
{
    class Fish : Food, IEdible, IPoisonious
    {
        public string AnimalType { get; set; }
        public bool WithScales { get; set; }
        
        public Fish(ColourEnum colour, double weight, string type, bool withScales)
            :base(colour, weight)
        {
            AnimalType = type;
            WithScales = withScales;
        }

        public string Prepare()
        {
            return "It's cooked";
        }

        public string Poisonious(bool answer)
        {
            return answer ? "Do not eat, it is Poisonious!" : "You can eat it, It's not posionious.";
        }


        public string Taste()
        {
            return "Amazing test";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nFood Colour: {Colour}\nWeight: {Weight}\nScale: {WithScales}";
        }

        //Add to Main()
        //Fish fish1 = new Fish();
        //fish1.Colour = ColourEnum.Red;
        //fish1.Weight = 5.5;
        //fish1.WithScales = 3;

        //Console.WriteLine();

        //Console.WriteLine(fish1.AnimalType());
        //Console.WriteLine(fish1.Poisonious(true));
        //Console.WriteLine(fish1.Prepare());
        //Console.WriteLine(fish1.Taste());

        //Console.WriteLine();
        //Console.WriteLine(fish1.ToString());
    }
    
}
