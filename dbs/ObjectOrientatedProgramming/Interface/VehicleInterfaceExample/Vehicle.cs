using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.VehicleInterfaceExample
{
    class Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Colour { get; set; }

        public Vehicle (int wheels, string colour)
        {
            NumberOfWheels = wheels;
            Colour = colour; 
        }

        public override string ToString()
        {
            return $"There are {NumberOfWheels} wheels and it is {Colour}";
        }
        public bool MoveForward()
        {
            return true;
        }

        public bool Turn(string direction)
        {
            if(direction == "left")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Reverse()
        {
            return true;
        }
    }
}
