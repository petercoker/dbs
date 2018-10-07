using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.AbstractClass.AbstractEmployeeExample
{
    abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public StatusEnum Status { get; set; }
        public ManagerEnum Manager { get; set; }

        public Employee()
        { }

        public Employee(int id, string name, string gender, int phone, int age, StatusEnum status, ManagerEnum manager)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Phone = phone;
            Age = age;
            Status = status;
            Manager = manager;
        }

        public override string ToString()
        {
            return $"{Name} is a {Status} employee who is {Age} and reports to {Manager}"; 
        }
        //creating the abstract method of GetIncome, no implementation
        //Just setting up the structure
        public abstract double GetIncome();
    }
}
