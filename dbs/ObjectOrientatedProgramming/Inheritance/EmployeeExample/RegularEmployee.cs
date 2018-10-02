using System;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeExample
{
    class RegularEmployee : Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }

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
    }
}
