using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex11
    {
        public void GetPinDoWhile()
        {
            string input;
            int correctPin = 1234;
            int userPin;
            int goes = 0;

            do
            {
                goes++;
                Console.WriteLine("Please enter pin");
                input = Console.ReadLine();
                userPin = int.Parse(input);

                if (userPin == correctPin)
                {
                    Console.WriteLine("Correct Pin");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pin");
                }
            }
            while (goes < 3);

            Console.WriteLine("Goodbye");


        }
    }
}
