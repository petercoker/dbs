using System;

namespace dbs.RecapExercises
{
    class ex8
    {
        public void GuessNumber()
        {
            int player1, player2;
            const int GuessLimit = 4;

            Console.Write("First player enter a number: ");
            player1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("You have 3 chances to guess player 1's number: ");

            for (int i = 0; i <= GuessLimit; i++)
            {
                player2 = Convert.ToInt32(Console.ReadLine());

                if (player1 == player2)
                {
                    Console.WriteLine("Congratulations you guessed correctly. Player one chose {0}", player1);
                    break;
                }

                else if (player2 > player1)
                {
                    Console.WriteLine("Wrong, you guessed too high, please try again");
                }

                else
                {
                    Console.WriteLine("Wrong, you guessed too low, please try again");

                }

            }

            Console.WriteLine("Sorry player one guessed {0}", player1);

        }

    }
}