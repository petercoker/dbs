using System;

namespace dbs.RecapExercises
{
    class ex5
    {
        public void GetTemperature()
        {
            int temp;

            Console.Write("Enter the temp: ");
            temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(((temp - 32) * 5) / 9);
        }

    }
}