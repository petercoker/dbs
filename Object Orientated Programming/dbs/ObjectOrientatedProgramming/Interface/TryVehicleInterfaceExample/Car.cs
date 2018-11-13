using System;
using System.Runtime.InteropServices;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    public class Car : Vehicle, IEngine
    {
        public int NumberOfDoors { get; set; }
        public FuelTypeEnum FuelType { get; set; }
        public double EngineSize { get; set; }

        public Car(int numberOfWheels, string colour, int numberOfDoors, FuelTypeEnum fuelType, double engineSize)
            : base(numberOfWheels, colour)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
            EngineSize = engineSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nVehicle number of Doors: {NumberOfDoors}\nVehicle FuelType: {FuelType}\nVehicle Engine Size: {EngineSize} Liters";
        }

        public bool StartEngine()
        {
            return true;
        }

        public bool TurnOffEngine()
        {
            return true;
        }

        //Add to Main()
        //Car car = new Car(4, "Blue", 4, FuelTypeEnum.Diesel, 5.6);
        //Console.WriteLine(car);

        //Possible ways to use the methods. Other variations can be done. These are just examples
        //Console.WriteLine(car.StartEngine() == true ? "Engine has started, Move forward" : "The engine has started");

        //Alternate way
        //if (car.StartEngine() == true)
        //{
        //    Console.WriteLine("Engine has started, Move forward"));
        //}

        //else
        //{
        //    Console.WriteLine("The engine has started");
        //}

        //Console.WriteLine(car.TurnOffEngine() == true ? "The engine is off you can get out now" : "Turn the engine off before you get out of the car");

        //Alternate way
        //if (car.TurnOffEngine() == true)
        //{
        //    Console.WriteLine("The engine is off you can get out now");
        //}
        //else
        //{
        //    Console.WriteLine("Turn the engine off before you get out of the car");
        //}
    }
}
