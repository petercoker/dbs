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

        public Vehicle()
        {

        }

        public Vehicle(int numberOfWheels, string colour)
        {

        }

        public bool MoveForward()
        {
            return true;
        }

        public bool Turn(string direaction)
        {
            bool right = false;

            if (right)
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

        public override string ToString()
        {
            return $"Test";
        }

    }
}
