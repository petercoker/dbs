using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.VehicleInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bike = new Bicycle(2, "Red", 7);
            Console.WriteLine(bike);

            Car car = new Car(4, "Blue", 4, FuelType.Petrol, 1.2);
            Console.WriteLine(car);

            //Possible ways to use the methods. Other variations can be done. These are just examples
            if(car.StartEngine() == true)
            {
                if(car.MoveForward()== true)
                {
                    Console.WriteLine("Engine has started, Move forward");
                }
                else
                {
                    Console.WriteLine("The engine has started");
                }
            }

            
            if(car.Turn("left"))
            {
                Console.WriteLine("You can turn left when the filter is on");
            }
            else
            {
                Console.WriteLine("Wait for the light to change");
            }

            if (car.TurnOffEngine()== true)
            {
                Console.WriteLine("The engine is off you can get out now");
            }
            else
            {
                Console.WriteLine("Turn the engine off before you get out of the car");
            }
        }
    }
}
