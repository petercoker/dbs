using System;
using System.Collections;
using System.CodeDom;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.CA
{
    class Person
    {
        public List<string> Name { get; set; }
        public List<int> Phone { get; set; }
        public List<string> Email { get; set; }

        public Person()
        {
            
        }

        public Person(List<string> name, List<int> phone, List<string> email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
