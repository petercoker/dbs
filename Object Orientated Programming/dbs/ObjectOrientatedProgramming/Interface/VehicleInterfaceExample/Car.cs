using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.VehicleInterfaceExample
{
    class Car : Vehicle, IEngine
    {
        public FuelType Fuel { get; set; }
        public double EngineSize { get; set; }
        public int NumberOfDoors { get; set; }

        public Car(int wheels, string colour, int doors, FuelType fuel, double size)
            :base(wheels, colour)
        {
            Fuel = fuel;
            EngineSize = size;
            NumberOfDoors = doors;
        }

        public override string ToString()
        {
            return base.ToString() + $", Fuel Type is {Fuel}, Engine Size is {EngineSize}, with {NumberOfDoors} doors";
        }

        public bool StartEngine()
        {
            return true;
        }

        public bool TurnOffEngine()
        {
            return true;
        }
    }
}
