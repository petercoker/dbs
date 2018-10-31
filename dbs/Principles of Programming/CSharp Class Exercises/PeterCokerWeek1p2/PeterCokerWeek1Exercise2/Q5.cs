using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise2
{
    class Q5
    {
        static void Main(string[] args)
        {
            //declare and initial 
            int mark1 = 44, mark2 = 51;
            double average;

            //sum

            average = (mark1 + mark2) / 2.0;

            Console.WriteLine("Average mark = {0}", average);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
