using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.CA
{
    class Student : Person
    {
        //public new List<int> StudentId { get; set; }
        private new List<int> studentId;
        public StudentStatusEnum Status { get; set; }
        //public List<int> StudentId { set; } //User can set not change the Id

        public List<int> StudentId
        {
            get { return studentId; }

            set
            {
                while (true)
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (value.Contains(number))
                    {
                        continue;
                    }

                    else
                    {
                        studentId = value;
                    }
                }
                

            }
        }

        public Student()
        {

        }

        public Student(List<string> name, List<int> phone, List<string> email, List<int> studentId, StudentStatusEnum status)
            : base(name, phone, email)
        {
            StudentId = studentId;
            Status = status;
        }
        

        ////Unqiue Number
        //var numbers = new List<int>();

        //while (numbers.Count < 5)
        //{
        //    Console.Write("Enter a number: ");
        //    var number = Convert.ToInt32(Console.ReadLine());
        //    if (numbers.Contains(number))
        //    {
        //        Console.WriteLine("You've previously entered " + number);
        //        continue;
        //    }

        //    numbers.Add(number);
        //}

        //numbers.Sort();

        //foreach (var number in numbers)
        //    Console.WriteLine(number);
    }
}
