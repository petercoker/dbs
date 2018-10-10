using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    public class Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Colour { get; set; }

        public Vehicle(int numberOfWheels, string colour)
        {
            NumberOfWheels = numberOfWheels;
            Colour = colour;
        }

        public override string ToString()
        {
            return $"Vehicle's number of wheel: {NumberOfWheels}\nColour of Vehicle: {Colour}";
        }

        public bool MoveForward()
        {
            return true;
        }

        public bool Turn(string direction)
        {

            return direction == "left" || direction == "Left" ? true : false;
             
            //Alternate way
            //if (direction == "left" || direction == "Left")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool Reverse()
        {
            return true;
        }


    }
}
