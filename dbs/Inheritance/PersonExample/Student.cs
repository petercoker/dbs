using System;

namespace dbs.Inheritance.PersonExample
{
    //This ":" keyword to e.g class Student : Person meaning that Student inheritance from Person
    class Student : Person
    {
        //Add to Main()
        //Student student1 = new Student("Mary", "Murphy", 123, 234, 2);
        //Console.WriteLine(student1.ToString());

        public int StudentNumber { get; set; }
        //public int YearAttend { get; set; }
        public YearEnum YearAttend { get; set; } //Add the enum
        public Student()
        {

        }

        public Student(string firstName, string lastName, int phone, int studentNumber, YearEnum yearAttend)
            : base(firstName, lastName, phone)
        {
            StudentNumber = StudentNumber;
            YearAttend = yearAttend;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTheir student no is {StudentNumber}" + $"and they are in {YearAttend}";
        }

    }
}