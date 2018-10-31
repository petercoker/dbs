using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q3
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.Write("Please enter your age ");
            userAge = int.Parse(Console.ReadLine());
            
            if (userAge >= 18 && userAge <= 30)
            {
                Console.Write("Eligible to go on vacation");
            }

            else

            {
                Console.Write("Not Eligible to on vacation");
            }

            Console.ReadLine();
        }
    }
}
