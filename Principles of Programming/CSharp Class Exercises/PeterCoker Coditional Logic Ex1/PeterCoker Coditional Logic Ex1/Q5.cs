using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q5
    {
        static void Main(string[] args)
        {

            int number;

            Console.Write("Enter a number between 1 and 4 = ");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Diamonds");
            }

            else if (number == 2)
            {
                Console.WriteLine("Hearts");
            }

            else if (number == 3)
            {
                Console.WriteLine("Clubs");
            }

            else if (number == 4)
            {
                Console.WriteLine("Spades");
            }

            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.ReadLine();
        }
    }
}
