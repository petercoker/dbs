using System;

namespace dbs.ObjectOrientatedProgramming.InClassExam.Liffey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Liffey Co application*****");
            SweetShop sw1 = new SweetShop("DBS SweetShop", "Peter Coker", 5);
            Console.WriteLine(sw1.ToString() + sw1.GreetCustomer() + sw1.ServeCustomer());


        }
    }
}