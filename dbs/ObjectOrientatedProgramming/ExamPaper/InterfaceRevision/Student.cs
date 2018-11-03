using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.InterfaceRevision
{
    class Student : Person, IClient
    {
        public int YearEnrolled { get; set; }
        public string Email { get; set; }
        public Student()
        { }
        public Student(string name, int phone, int yr, string email)
            : base(name, phone)
        {
            YearEnrolled = yr;
            Email = email;
        }

        public string DirectClient()
        {
            return "Please go to class";
        }

        public string GreetClient()
        {
            return $"Hello {Name} enjoy your classes today";
        }

        public override string ToString()
        {
            return $"{Name} enrolled in {YearEnrolled}";
        }
    }
}
