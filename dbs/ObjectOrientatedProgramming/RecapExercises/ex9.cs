using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex9
    {
        public void GetNumber()
        {
            //Declare Variables
            int secretNumber, guessedNumber;

            //Get player 1 to enter a number
            Console.WriteLine("Player 1 please enter number");
            secretNumber = int.Parse(Console.ReadLine());

            //Clears the screen
            Console.Clear();

            //Player 2 to start guessing
            Console.WriteLine("Please guess a number");

            for (int i = 0; i < 3; i++)
            {
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine($"congrats you guessed correctly, " +
                        $"the secret number was {secretNumber}");
                    break;
                }
                else if (i < 2)
                {
                    if (guessedNumber < secretNumber)
                    {
                        Console.WriteLine("Guess is too low");
                    }
                    else
                    {
                        Console.WriteLine("Guess is too high");
                    }
                }
                else
                {
                    Console.WriteLine($"You are out of guesses the secret" +
                        $"Number was {secretNumber}");
                }
            }
        }
    }
}