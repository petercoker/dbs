using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise2
{
    class Q1
    {
        static void Main(string[] args)
        {
            //Declare

            int x, y, sum;

            //Prompt

            Console.Write("Enter a number ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter another number ");
            y = int.Parse(Console.ReadLine());

            //increment

            x = x + 1;

            //sum

            sum = x + y;

            Console.WriteLine("Sum = {0}", sum);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
