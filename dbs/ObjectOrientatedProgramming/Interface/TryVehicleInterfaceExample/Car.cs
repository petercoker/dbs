using System;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    class Car : Vehicle, IEngine
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
        //Console.WriteLine("Methods");
        //Console.WriteLine(car.MoveForward());
        //Console.WriteLine(car.Turn("right"));
        //Console.WriteLine(car.Turn("left"));
        //Console.WriteLine(car.Reverse());
    }
}
