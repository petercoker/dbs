using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex8
    {
        public void GuessNumberWhile()
        {
            //Declare Variables
            int secretNumber, guessedNumber;
            int count = 0;

            //Get player 1 to enter a number
            Console.WriteLine("Player 1 please enter number");
            secretNumber = int.Parse(Console.ReadLine());

            //Clears the screen
            Console.Clear();

            //Player 2 to start guessing
            Console.WriteLine("Please guess a number");

            while (count < 3)
            {
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine($"congrats you guessed correctly, " +
                        $"the secret number was {secretNumber}");
                    count = 3;
                }
                else if (count < 2)
                {
                    if (guessedNumber < secretNumber)
                    {
                        Console.WriteLine("Guess is too low");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Guess is too high");
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine($"You are out of guesses the secret" +
                        $"Number was {secretNumber}");
                    count++;
                }
            }
        }
        

    }
}