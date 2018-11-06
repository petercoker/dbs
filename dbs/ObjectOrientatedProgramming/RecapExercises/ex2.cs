using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex2
    {
        public void GetEx2()
        {
            //declare variables
            string input;
            int number, remainder;

            //ask user to input number
            Console.WriteLine("Please enter a number");
            input = Console.ReadLine();
            number = int.Parse(input);

            //see if there is a remainder or not
            remainder = number % 5;

            //if statement 
            if (remainder == 0)
            {
                Console.WriteLine("High five");
            }
            else
            {
                Console.WriteLine("Thank you for usign the program ");
            }

        }


    }
}