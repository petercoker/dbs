using System;
using System.CodeDom;

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
            return base.ToString() + $"\nEmployee {ID}" + $"Name of Employee {Name}" + $"Gender: {Gender}" + $"Phone Numer: {Phone}" + $"Employee Status: {Status}" + $"Type of Manager: {Manager}";
        }


    }
}
