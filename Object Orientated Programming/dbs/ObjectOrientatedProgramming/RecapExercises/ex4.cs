using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex4
    {
        public void GetCircumference()
        {
            //declare variables
            string input;
            double radius, circumference;

            //take in radius
            Console.WriteLine("Please enter the radius");
            input = Console.ReadLine();
            radius = double.Parse(input);
            //calculate circumference
            circumference = 2 * Math.PI * radius;
            //print answer to the screen 
            Console.WriteLine("The circumference of the circle is " + circumference);

        }
    }
}