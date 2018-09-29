using System;
using System.Xml.Schema;
using dbs.ClassNotes;
using dbs.ClassNotes.ClassesObjects;
using dbs.IntroductionToClasses;
using dbs.IntroductionToClasses.BookExample;
using dbs.IntroductionToClasses.DrinkExample;
using dbs.IntroductionToClasses.FilmExample;
using dbs.RecapExercises;
using dbs.Inheritance.EmployeeExample;
using dbs.Inheritance.PersonExample;

namespace dbs
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(0, "James Bond", "Male", 23543322, StatusEnum.RemoteWorker, ManagerEnum.FloorManager);
            Contractor contractor = new Contractor(1, "Luke Cage", "Male", 123, StatusEnum.Fulltime, ManagerEnum.GeneralManager, 60, 116.67f);
            RegularEmployee regularEmployee = new RegularEmployee(2, "Dare Devil", "Male", 1234, StatusEnum.Fulltime,
                ManagerEnum.StandInManager, "Software Programmer", 500.00);

            Console.WriteLine("***Employee***");
            Console.WriteLine(employee.ToString());
            Console.WriteLine();
            Console.WriteLine("***Contractor***");
            Console.WriteLine(contractor.ToString());
            Console.WriteLine();
            Console.WriteLine("***Regular Employee***");
            Console.WriteLine(regularEmployee.ToString());

            Console.WriteLine();
            Console.WriteLine("***Sum***");
            Console.WriteLine("Contractor income: $" + contractor.GetIncome());
            Console.WriteLine("Regular Employee Monthly income: $" + regularEmployee.GetMonthlyIncome());




        }
    }
}
