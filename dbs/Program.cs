using System;
using dbs.ObjectOrientatedProgramming.ClassNotes.ClassesObjects;
using dbs.ObjectOrientatedProgramming.Inheritance;
using dbs.ObjectOrientatedProgramming.IntroductionToClasses;
using dbs.ObjectOrientatedProgramming.Inheritance.EmployeeExample;

namespace dbs
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularEmployee regEmp = new RegularEmployee(123, "Joyce", "Female", 1478, 35, StatusEnum.FullTime, ManagerEnum.John, "Developer", 30000);
            Contractor contEmp = new Contractor(098, "Brian", "Male", 1365, 42, StatusEnum.RemoteWorker, ManagerEnum.Sarah, 120, 19);

            Console.WriteLine(regEmp.ToString() + " Their mothly wage is {0} ", regEmp.GetMonthlyIncome());
            Console.WriteLine(contEmp.ToString() + " Their monthly income is {0} ", contEmp.GetIncome());

        }
    }
}
