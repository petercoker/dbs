using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise1
{
    class Q7
    {
        static void Main(string[] args)
        {
            //Declare
            double num1, num2, sum;

            //Prompt

            Console.Write("Enter a number ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter another number ");
            num2 = double.Parse(Console.ReadLine());

            //sum

            sum = num1 / num2;

            Console.WriteLine("= {0}", sum);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
           
}
