using System;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    class Bicycle : Vehicle
    {
        public int NumberOfGears { get; set; }

        public Bicycle(int numberOfWheels, string colour, int numberOfGears)
            :base (numberOfWheels, colour)
        {
            NumberOfGears = numberOfGears;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nBicyle's Gear: {NumberOfGears}";
        }

        //Bicycle bicycle = new Bicycle(2, "red", 5);
        //Console.WriteLine(bicycle);
        //Console.WriteLine("Methods");
        //Console.WriteLine(bicycle.MoveForward());
        //Console.WriteLine(bicycle.Turn("right"));
        //Console.WriteLine(bicycle.Turn("left"));
        //Console.WriteLine(bicycle.Reverse());
    }

}
