using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise2
{
    class Q4
    {
        static void Main(string[] args)
        {
            //Declare

            int a, b, c, d, r, sum;
          
            //Prompt

            Console.Write("Enter a number for a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter a number for b = ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter a number for c = ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Enter a number for d = ");
            d = int.Parse(Console.ReadLine());

            Console.Write("Enter a number for r = ");
            r = int.Parse(Console.ReadLine());


            // sum

            sum = 4 / (3 * (r + 34)) - 9 * (a + b * c) + 3 + (d * (2 + a)) / (a + b * d);

            Console.WriteLine("Sum = {0}", sum);



            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
