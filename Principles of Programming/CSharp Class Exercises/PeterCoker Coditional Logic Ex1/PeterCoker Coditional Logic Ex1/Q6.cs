using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q6
    {
        static void Main(string[] args)
        {
            int number;
            string day;

            Console.Write("Please enter a number between 1 and 7 ");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    day = "Monday";
                    break;

                case 2:
                    day = "Tuesday";
                    break;

                case 3:
                    day = "Wednesday";
                    break;

                case 4:
                    day =  "Thurday";
                    break;

                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;

                case 7:
                    day = "Sunday";
                    break;

                default:
                    day = "Invalid number";
                    break;

            }

            Console.WriteLine(day);
           
            Console.ReadLine();
        }
    }
}
