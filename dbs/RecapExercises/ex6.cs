using System;

namespace dbs.RecapExercises
{
    class ex6
    {
        public void GetNumberBetween()
        {
            int number;
            const int limit = 10;

            Console.Write("Enter a number between 1-20: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number > limit ? "The number is high" : "The number is low");


        }
    }
}