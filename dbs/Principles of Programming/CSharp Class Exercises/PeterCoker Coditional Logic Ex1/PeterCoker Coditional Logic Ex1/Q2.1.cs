using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q2
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.Write("Please enter your age ");
            userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You are eligibel to vote");
            }

            else
            {
                Console.WriteLine("You cannot vote");
            }

            
            Console.ReadLine();
        }
    }
}
