using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.VehicleInterfaceExample
{
    class Bicycle :Vehicle
    {
        public int NoOfGears { get; set; }

        public Bicycle(int wheels, string colour, int gears)
            : base(wheels, colour)
        {
            NoOfGears = gears;    
        }

        public override string ToString()
        {
            return base.ToString() + $" and has {NoOfGears} gears";
        }
    }
}
