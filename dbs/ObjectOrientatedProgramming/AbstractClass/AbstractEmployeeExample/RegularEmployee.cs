using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.AbstractClass.AbstractEmployeeExample
{
    class RegularEmployee: Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }

        public RegularEmployee()
        { }
        public RegularEmployee(int id, string name, string gender, int phone, int age, StatusEnum status, ManagerEnum manager, string title, double salary)
            : base(id, name, gender, phone, age, status, manager)
        {
            Title = title;
            Salary = salary;
        }

        public override double GetIncome()
        {
            return Salary / 12;
        }

        public override string ToString()
        {
            return base.ToString() 
                + $"Their title is {Title} with a {Salary} salary"; 
        }

    }
}
