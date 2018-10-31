using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Q4
    {
        static void Main(string[] args)
        {
            int guess, serectNum;


            Random random = new Random();

            serectNum = random.Next(0, 21); 

            Console.WriteLine("Guess the secret number between 0 and 20?\n");

            Console.Write("Enter your number: ");
            guess  = int.Parse(Console.ReadLine());

            if (guess < serectNum)
            {
                Console.WriteLine("\nYour guess is too low, please try again");
            }
            

            else if (guess > serectNum)
            {
                Console.WriteLine  ("\nYour guess is too high, please try again");
            }

            else
            {
                Console.Write("\n\aWell done, you guessed correctly!");
            }

            Console.WriteLine("\nSecret number is {0}", serectNum);

            Console.ReadLine();

        }
    }
}
