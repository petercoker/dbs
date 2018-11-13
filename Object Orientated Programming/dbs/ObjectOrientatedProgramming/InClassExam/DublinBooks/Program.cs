using System;

namespace dbs.ObjectOrientatedProgramming.InClassExam.DublinBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            eBook eb1 = new eBook("Harry Potter", "JK", 2015, 12345, 10.00, 5.0);
            Console.WriteLine("*****Dublin Books application*******");
            Console.WriteLine(eb1.ToString());
            Console.WriteLine($"Gross price {eb1.GetGrossPrice()}");

           
        }
    }
}