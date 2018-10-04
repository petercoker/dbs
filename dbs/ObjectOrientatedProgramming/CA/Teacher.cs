using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.CA
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
    }
}
