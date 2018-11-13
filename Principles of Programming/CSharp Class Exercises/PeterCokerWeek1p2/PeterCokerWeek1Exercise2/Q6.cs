using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise2
{
    class Q6
    {
        static void Main(string[] args)
        {

            //declare 
            int seconds, minutes, totalSeconds;

            //prompt
            Console.Write("Enter the number of seconds: ");
            totalSeconds = int.Parse(Console.ReadLine());

            //sum
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;

            
            Console.WriteLine("Total Second {0} = {1} minutes and {2} seconds", totalSeconds, minutes, seconds);

            //Console.WriteLine($"{totalSeconds} Total seconds = {minutes} minutes and {seconds} seconds");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}
