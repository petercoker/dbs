using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Q6
    {
        static void Main(string[] args)
        {
            //string Head, Tail;
            string coin, guess;
            int number;

            Random random = new Random();
            number = random.Next(0, 2);

            coin = (number == 0) ? "heads" : "tails";

            Console.Write("Guess, heads or tails? ");
            guess = Console.ReadLine();
           

            if (!(guess == coin))

            {
                Console.WriteLine("Guess is incorrect");
            }

            else
            {
                Console.WriteLine("Gusess is correct");
            }

            Console.WriteLine("The flip of the coin has given {0}", coin);

            Console.ReadLine();

            /*
            //declaration of variables
            string coin, guess;
            int number;

            Random random = new Random();

            //generating random number between 0 and 1
            number = random.Next(0, 2);//min 0 and max is 1

            //assiging heads or tails to variable coin
            coin = (number == 0) ? "heads" : "tails";
            //prompt the user to guess the flip of the coin
            Console.WriteLine("Guess, heads or tails?");
            guess = Console.ReadLine();

            if (guess.ToLower().Equals(coin))
            {
                Console.WriteLine("Your guess is correct");
            }
            else
            {
                Console.WriteLine("Incorrect guess, try again");
            }
            Console.WriteLine("The flip of the coin has given {0}", coin);
            Console.ReadLine();
            */  

        }
    }
}
