using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Q1
    {
        static void Main(string[] args)
        {
            int num;

            

            Console.WriteLine("Please enter a number between 0 and 1000\n");
            Console.Write("Number: ");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num >= 0 && num <= 1000)
            {
                if( num % 2 == 0)
                {
                    Console.Write("The number you entered is even");
                }

                else
                {
                    Console.Write("The number you entered is odd");

                }
            }

            else
            {
                Console.WriteLine("You entered an invalid number");
            }






            Console.ReadLine();
        }

        
    }
}
