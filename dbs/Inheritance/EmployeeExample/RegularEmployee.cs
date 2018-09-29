using System;

namespace dbs.Inheritance.EmployeeExample
{
    class RegularEmployee : Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }
        

        public RegularEmployee(int iD, string name, string gender, int phone, StatusEnum status, ManagerEnum manager, string title, double salary)
            :base(iD, name, gender, phone, status, manager)
        {
            Title = title;
            Salary = salary;
        }

        public double GetMonthlyIncome(int monthly = 12)
        {
            return Salary / monthly;
        }

        public override string ToString()
        {
            return base.ToString() + $"Title: {Title}" + $"Salary: {Salary}";
        }
    }
}
