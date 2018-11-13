using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.PassengerExample
{
    class Address
    {
        public string HouseNumber { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public Address()
        {

        }

        public override string ToString()
        {
            return $"{HouseNumber} {Street},\n{City}\n{County}";
        }
    }
}
