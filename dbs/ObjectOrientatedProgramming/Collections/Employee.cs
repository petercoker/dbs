using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Collections
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Wage { get; set; }

        public Employee()
        {

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} earns {Wage}";
        }
    }
}
