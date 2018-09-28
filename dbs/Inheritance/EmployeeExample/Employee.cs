using System;

namespace dbs.Inheritance.EmployeeExample
{
    class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Phone { get; set; }

        public StatusEnum Status { get; set; }

        public ManagerEnum Manager { get; set; }

        public Employee()
        {

        }

        public Employee(int iD, string name, string gender, int phone, StatusEnum status, ManagerEnum manager)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Phone = phone;
            Status = status;
            Manager = manager;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTheir student no is {ID}" + $"and they are in {Name}";
        }

        //public int GetIncome(int income)
        //{

        //}
    }
}
