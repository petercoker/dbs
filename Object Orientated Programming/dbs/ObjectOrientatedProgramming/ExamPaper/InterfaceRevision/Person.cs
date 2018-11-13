using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.InterfaceRevision
{
    class Person
    {
        public string Name { get; set; }
        public int Phone { get; set; }

        public Person()
        { }

        public Person(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }
        
    }
}
