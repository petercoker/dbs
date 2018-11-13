using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeExample
{
    class RegularEmployee: Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }

        public RegularEmployee()
        {

        }
        public RegularEmployee(int id, string name, string gender, int phone, int age, StatusEnum status, ManagerEnum manager, string title, double salary)
            : base(id, name, gender, phone, age, status, manager)
        {
            Title = title;
            Salary = salary;
        }

        public double GetMonthlyIncome()
        {
            return Salary / 12;
        }

        public override string ToString()
        {
            return base.ToString() + $"Their title is {Title} with a {Salary} salary";
        }

        //Add to Main()
        //RegularEmployee regEmp = new RegularEmployee(123, "Joyce", "Female", 1478, 35, StatusEnum.FullTime, ManagerEnum.John, "Developer", 30000);
        //Contractor contEmp = new Contractor(098, "Brian", "Male", 1365, 42, StatusEnum.RemoteWorker, ManagerEnum.Sarah, 120, 19);

        //Console.WriteLine(regEmp.ToString() + " Their mothly wage is {0} ", regEmp.GetMonthlyIncome());
        //Console.WriteLine(contEmp.ToString() + " Their monthly income is {0} ", contEmp.GetIncome());
    }
}
