using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise1
{
    class Q5
    {
        static void Main(string[] args)
        {
            //Declare

            int var;

            //Promopt
            Console.WriteLine("Enter a number ");
            var = int.Parse(Console.ReadLine());

            //increment

            var = var + 1;

            //sum

            Console.Write("sum = {0} ", var);



            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
           
}
