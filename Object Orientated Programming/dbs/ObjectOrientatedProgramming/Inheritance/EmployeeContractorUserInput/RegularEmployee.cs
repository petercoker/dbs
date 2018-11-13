using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeContractorUserInput
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

        public double GetMonthlyIncome()
        {
            return Salary / 12;
        }

        public override string ToString()
        {
            return base.ToString() + $"Their title is {Title} with a {Salary} salary"; 
        }

        //Add to Main()
        //RegularEmployee regEmp = new RegularEmployee();

        //Console.WriteLine("Please enter their ID");
        //regEmp.ID = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter the persons name");
        //regEmp.Name = Console.ReadLine();
        //Console.WriteLine("Please enter their phone");
        //regEmp.Phone = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please enter their age");
        //regEmp.Age = int.Parse(Console.ReadLine());
        //regEmp.Status = StatusEnum.FullTime;
        //regEmp.Manager = ManagerEnum.Joe;
        //Console.WriteLine("Please enter their title");
        //regEmp.Title = Console.ReadLine();
        //Console.WriteLine("Please enter their salary");
        //regEmp.Salary = int.Parse(Console.ReadLine());

        //Console.WriteLine(regEmp.ToString());

    }
}
