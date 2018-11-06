using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex6
    {
        public void GetNumberBetween()
        {
            string input;
            int number;

            Console.WriteLine("Please enter a number");
            input = Console.ReadLine();
            number = int.Parse(input);

            while (number < 1 || number > 20)
            {
                Console.WriteLine("Number must be between 1 and 20");
                input = Console.ReadLine();
                number = int.Parse(input);
            }
            if (number > 10)
            {
                Console.WriteLine("The number is high");
            }
            else if (number < 10)
            {
                Console.WriteLine("The number is low");
            }
            else
            {
                Console.WriteLine("The number is 10");
            }

        }
    }
}