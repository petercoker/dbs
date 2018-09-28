using System;

namespace dbs.RecapExercises
{
    class ex1
    {
        public void GetName()
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name);
            //Console.WriteLine($"Welcome {name}"); //Alternate way
        }

        public void AddNumbers()
        {
            const int NumbersAsked = 3;
            int sum = 1, number;

            Console.WriteLine("Enter 3 numbers to Add them: ");

            for (int i = 1; i <= NumbersAsked; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}