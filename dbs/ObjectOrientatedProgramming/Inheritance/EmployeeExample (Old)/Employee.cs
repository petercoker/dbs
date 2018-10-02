using System;
using System.CodeDom;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeExample
{
    class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Phone { get; set; }

        public StatusEnum Status { get; set; }

        public ManagerEnum Manager { get; set; }

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
            return $"\nEmployee ID: {ID}" + $"\nEmployee Name: {Name}" + $"\nGender: {Gender}" + $"\nPhone Numer: {Phone}" + $"\nEmployee Status: {Status}" + $"\nType of Manager: {Manager}";
        }

        //Add to main
        //Employee employee = new Employee(0, "James Bond", "Male", 23543322, StatusEnum.RemoteWorker, ManagerEnum.FloorManager);
        //Contractor contractor = new Contractor(1, "Luke Cage", "Male", 123, StatusEnum.Fulltime, ManagerEnum.GeneralManager, 60, 116.67f);
        //RegularEmployee regularEmployee = new RegularEmployee(2, "Dare Devil", "Male", 1234, StatusEnum.Fulltime,
        //    ManagerEnum.StandInManager, "Software Programmer", 500.00);

        //Console.WriteLine("***Employee***");
        //    Console.WriteLine(employee.ToString());
        //    Console.WriteLine();
        //    Console.WriteLine("***Contractor***");
        //    Console.WriteLine(contractor.ToString());
        //    Console.WriteLine();
        //    Console.WriteLine("***Regular Employee***");
        //    Console.WriteLine(regularEmployee.ToString());

        //    Console.WriteLine();
        //    Console.WriteLine("***Sum***");
        //    Console.WriteLine("Contractor income: $" + contractor.GetIncome());
        //    Console.WriteLine("Regular Employee Monthly income: $" + regularEmployee.GetMonthlyIncome());


    }
}
