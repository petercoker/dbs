using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Teacher : Employee
    {
        public TaughtEnum Taught { get; set; }

        public Teacher()
        {
            
        }

        public Teacher(List<string> name, List<int> phone, List<string> email, List<double> salary, TaughtEnum taught)
            : base(name, phone, email, salary)
        {
            Taught = taught;
        }

        public override string ToString()
        {
            return base.ToString() + $"Teacher: {Name}\nPhone: {Phone}\nEmail: {Email}\nTaught: {Taught}\nSalary: {Salary}";
        }
    }
}
