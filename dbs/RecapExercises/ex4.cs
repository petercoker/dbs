using System;

namespace dbs.RecapExercises
{
    class ex4
    {
        public void GetCircumference()
        {
            int radius;

            Console.Write("Enter the radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(2 * Math.PI * radius);
        }
    }
}