using System;
using System.Collections.Generic;
using System.Text;

namespace dbs.ObjectOrientatedProgramming.InClassExam.Liffey
{
    interface ICustomer
    {
        string CustomerName { get; set; }
        string GreetCustomer();
        string ServeCustomer();
    }
}
