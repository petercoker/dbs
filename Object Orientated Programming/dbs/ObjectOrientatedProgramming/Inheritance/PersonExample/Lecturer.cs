using System;

namespace dbs.ObjectOrientatedProgramming.Inheritance.PersonExample
{
    class Lecturer : Person
    {
        public string Department { get; set; }
        public int YearJoined { get; set; }
        //public DateTime YearJoined { get; set; }
        
        public Lecturer()
        {

        }

        public Lecturer(string firstName, string lastName, int phone, string department, int yearJoined)
        //public Lecturer(string firstName, string lastName, int phone, string department, DateTime yearJoined)
            : base(firstName, lastName, phone)
        {
            Department = department;
            YearJoined = yearJoined;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLecturer Department is {Department}" + $"and Lecturer Joined {YearJoined}";
        }

        public int YearsEmployed()
        //public TimeSpan YearsEmployed()
        {
            //DateTime year = DateTime.Today;
            //return YearJoined - year; //Find out how to add DateTime of the current year
            return 2018 - YearJoined;
        }

        //Add to Main()
        //Lecturer lecturer = new Lecturer("Sam", "Brown", 1234, "IT", 2013);
        //Console.WriteLine(lecturer.ToString());
        //Console.WriteLine($"They have work here for {lecturer.YearsEmployed()} years");



    }
}
