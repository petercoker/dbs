using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex3
    {
        public void CompareTwoNumbers()
        {
            //Declare variables
            int number1, number2;
            string input;

            //Ask the user for 2 numbers
            Console.WriteLine("Please enter first number");
            input = Console.ReadLine();
            number1 = int.Parse(input);

            Console.WriteLine("Please enter second number");
            input = Console.ReadLine();
            number2 = int.Parse(input);

            //check if numbers are equal
            if (number1 == number2)
            {
                Console.WriteLine("The numbers are equal");
            }
            //check if first number is bigger than second
            else if (number1 > number2)
            {
                Console.WriteLine("number 1 is bigger than number 2");
            }
            //check if first number is smaller than the second
            else if (number1 < number2)
            {
                Console.WriteLine("Number 1 is smaller than number 2");
            }
            else
            {
                Console.WriteLine("Wrong input type");
            }

        }
    }
}