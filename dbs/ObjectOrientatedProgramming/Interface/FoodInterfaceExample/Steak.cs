using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.FoodInterfaceExample
{
    class Steak :Food, IEdible
    {
        public string AnimalType { get; set; }
        public Steak(ColourEnum c, double w )
            :base(c,w)
        {

        }

        

        public string Prepare()
        {
            return "Medium rare please";
        }

        public  string Taste()
        {
            return "Tastes like steak";
        }


        //Steak steak = new Steak(ColourEnum.Red, 1);

        //Console.WriteLine(steak);
        //Console.WriteLine(steak.Prepare());
        //Console.WriteLine(steak.Taste());
    }
}
