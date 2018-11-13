using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise1
{
    class Q6
    {
        static void Main(string[] args)
        {

            //Declare

            int num1, num2, sum;

            //Prompt

            Console.Write("Enter a number ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number ");
            num2 = int.Parse(Console.ReadLine());

            //increment

            sum = num1 + num2 + 2;

            //sum

            Console.WriteLine("Total is {0}", sum);



            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
           
}
