using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.FoodInterfaceExample
{
    class Fish :Food, IEdible, IPoisonous
    {
        public string AnimalType { get; set; }
        public bool WithScales { get; set; }

        public Fish(ColourEnum c, double w, string type, bool scales)
            :base(c,w)
        {
            AnimalType = type; //Why ?
            WithScales = scales;
        }

        public string Prepare()
        {
            return "Grill it";
        }

        public string Taste()
        {
            return "Tastes like fish";
        }

        public string Poisonous(bool ans)
        {
            if(ans == true)
            {
                return "Do not eat the fish!";
            }
            else
            {
                return "Go ahead eat the fish";
            }
        }

        //Fish fish = new Fish(ColourEnum.White, 0.25, "water base", true);
        //Console.WriteLine(fish);
        //Console.WriteLine(fish.Taste());
        //Console.WriteLine(fish.Prepare());
        //Console.WriteLine(fish.Poisonous(true));
        //Console.WriteLine(fish.Poisonous(false));

    }
}
