using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Employee : Person
    {
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(string name, int phone, string email, int employeeID, double salary)
            : base(name, phone, email)
        {
            EmployeeID = employeeID;
            Salary = salary;
        }
    }
}
