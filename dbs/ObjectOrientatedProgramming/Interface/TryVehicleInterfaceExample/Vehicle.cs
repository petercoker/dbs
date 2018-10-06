using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    class Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Colour { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int numberOfWheels, string colour)
        {
            NumberOfWheels = numberOfWheels;
            Colour = colour;
        }

        public bool MoveForward()
        {
            return true;
        }

        public bool Turn(string direaction)
        {
            bool right = false;


            return right ? true : false;
        }

        public bool Reverse()
        {
            return true;
        }

        public override string ToString()
        {
            return $"Vehicle's number of wheel: {NumberOfWheels}\nColour of Vehicle: {Colour}";
        }

    }
}
