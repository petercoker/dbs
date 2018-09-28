using System;

namespace dbs.RecapExercises
{
    class ex3
    {
        public void CompareTwoNumbers()
        {
            int number1, number2;

            Console.Write("Enter 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            if (number1 == number2)
            {
                Console.WriteLine("The numbers are equal");
            }

            else if (number1 < number2)
            {
                Console.WriteLine("The first number is bigger than the second number");
            }

            else
            {
                Console.WriteLine("The first number is smaller than the second number");
            }
        }
    }
}