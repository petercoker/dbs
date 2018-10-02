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
        public int Age { get; set; }
        public StatusEnum Status { get; set; }
        public ManagerEnum Manager { get; set; }

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

        //Add to main 
        // RegularEmployee regEmp = new RegularEmployee(123, "Joyce", "Female", 1478, 35, StatusEnum.FullTime, ManagerEnum.John, "Developer", 30000);
            //Contractor contEmp = new Contractor(098, "Brian", "Male",1365, 42, StatusEnum.RemoteWorker, ManagerEnum.Sarah, 120, 19);

            //Console.WriteLine(regEmp.ToString() + " Their mothly wage is {0} ", regEmp.GetMonthlyIncome());
           // Console.WriteLine(contEmp.ToString() + " Their monthly income is {0} ", contEmp.GetIncome());


           
        
    }
}
