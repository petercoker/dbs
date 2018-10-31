using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex1
    {
        public void Exercirse1()
        {
            //Declare variables
            string input, name;
            int number1, number2, number3;
            int result;

            //Ask the user for their name
            Console.WriteLine("Please enter your name");
            //read in the name from the user
            name = Console.ReadLine();
            //Print welcome message
            Console.WriteLine("Welcome " + name);

            //ask the user for a number
            Console.WriteLine("Please enter a number");
            input = Console.ReadLine();
            number1 = int.Parse(input);
            //ask the user for the second number
            Console.WriteLine("Please enter another number");
            input = Console.ReadLine();
            number2 = int.Parse(input);
            //ask the user for the third number
            Console.WriteLine("Please enter a third number");
            input = Console.ReadLine();
            number3 = int.Parse(input);
            //show the user the numbers they picked
            Console.WriteLine("You chose " + number1 + "," + number2 + "," + number3);

            //Add the numbers together
            result = number1 + number2 + number3;
            Console.WriteLine("All the numbers added together are " + result);
            //multiply the first number by the second
            result = number1 * number2;
            Console.WriteLine("First number * second number is " + result);
            //subtract the first number from the second
            result = number2 - number1;
            Console.WriteLine("second number - first number is " + result);
            Console.ReadLine();
        }
        
    }
}