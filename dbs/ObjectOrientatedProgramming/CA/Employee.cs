using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.CA
{
    class Employee : Person
    {
        public List<double> Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(List<string> name, List<int> phone, List<string> email, List<double> salary)
            : base(name, phone, email)
        {
            Salary = salary;
        }
    }
}
