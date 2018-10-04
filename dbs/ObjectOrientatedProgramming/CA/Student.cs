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
                studentId = value;

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

        public override string ToString()
        {
            return base.ToString() + $"Student ID: {StudentId}\nStudent: {Name}\nStatus: {Status}\nPhone: {Phone}\nEmail: {Email}";
        }
    }
}
