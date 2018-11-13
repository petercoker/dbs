using System;
using System.Collections.Generic;
using System.Text;

namespace dbs.ObjectOrientatedProgramming.InClassExam.Liffey
{
    class Shop
    {
        public string Name { get; set; }
        public string Owner { get; set; }

        public Shop()
        {

        }


        public Shop(string name, string owner)
        {
            Name = name;
            Owner = owner;
        }


    }
}
