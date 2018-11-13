using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Q5
    {
        static void Main(string[] args)
        {
            int randomNum;
            string month = " ";

            Random random = new Random();

            randomNum = random.Next(1, 13);

            //Console.WriteLine("Guess a number between 1 and 12");

            //Console.Write("Enter your number: ");
            //randomNum = int.Parse(Console.ReadLine());

            switch (randomNum)
            {
                case 1:

                    month = "January";

                    break;

                case 2:

                    month = "February";

                    break;

                case 3:

                    month = "March";

                    break;

                case 4:

                    month = "April";

                    break;

                case 5:

                    month = "May";

                    break;

                case 6:

                    month = "June";

                    break;

                case 7:

                    month = "July";

                    break;

                case 8:

                    month = "August";

                    break;

                case 9:

                    month = "September";

                    break;

                case 10:

                    month = "October";

                    break;

                case 11:

                    month = "November";

                    break;

                case 12:

                    month = "December";

                    break;


            }
            
                    Console.WriteLine("Number {0} is for month {1}", randomNum, month);

                    


            

            

            Console.ReadLine();

        }
    }
}
