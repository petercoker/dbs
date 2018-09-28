using System;
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
            //Car car1 = new Car(); //Default constructor 

            //cart1.Colour = "Blue"; //Calling set
            //car1.NoOfDoors = 4; //Calling Set
            //car1.CurrentSpeed = 35; //Calling set

            //Car car1 = new Car("Blue", 4, 35); //You have to call more than one constructors
            //car1.Accelerate(60);
            //System.Console.WriteLine("Colour: {0}", car1.Colour);
            //System.Console.WriteLine("No of Doors: {0}", car1.NoOfDoors);
            //System.Console.WriteLine("Current Speed: {0}", car1.CurrentSpeed);

            //Console.ReadLine();

            //Person person1 = new Person("Peter", "Coker", 0123);
            //Person person2 = new Person("John", "Coker", 0123);

            ////Console.WriteLine("Person First Name: {0}", person1.FirstName);
            ////Console.WriteLine("Person Last Name: {0}", person1.LastName);
            ////Console.WriteLine("Person Phone: {0}", person1.Phone);
            ////Console.WriteLine(person1.ToString());
            ////Console.WriteLine(person2.ToString());

            ////Student student1 = new Student("Mary", "Murphy", 123, 234, 2);
            //Student student1 = new Student("Mary", "Murphy", 123, 234, YearEnum.Second); //Add the enum
            //Console.WriteLine(student1.ToString());

            //Lecturer lecturer = new Lecturer("Sam", "Brown", 1234, "IT", 2013);
            //Console.WriteLine(lecturer.ToString());
            //Console.WriteLine($"They have work here for {lecturer.YearsEmployed()} years");

            //int days;

            //Film film = new Film("Harry Potter", "Fantasy", "Boy Wizard", 5.5, .1);

            //Console.WriteLine($"The films name is {film.Title} and the genre is {film.Genre}");
            //Console.WriteLine($"Films Description is {film.Description} and its price is {film.Cost}");

            //Console.WriteLine("How many days did you rent it for?");
            //days = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The total cost is {film.TotalRental(days)}");


            //Console.WriteLine($"The VAT is {film.GetVat(film.TotalRental(days))}");

            Contractor contractor = new Contractor(1, "Peter", "Male", 123, StatusEnum.Fulltime, ManagerEnum.GeneralManager, 60, 116.67);
            Console.WriteLine(contractor.ToString());
            Console.WriteLine($"The Total cost is {contractor.GetIncome(7000)}");


        }
    }
}
