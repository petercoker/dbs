using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Food
    {
        public ColourEnum Colour { get; set; }
        public double Weight { get; set; }

        public Food(ColourEnum colour, double weight)
        {
            Colour = colour;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"colour is {Colour}, weight is {Weight}";
        }
    }
}
