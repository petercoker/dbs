using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex5
    {
        public void GetTemperature()
        {
            //Declare variables
            string input;
            double temp, celsius;
            //get fahrenheit from user
            Console.WriteLine("Please enter fahrenheit temp");
            input = Console.ReadLine();
            temp = double.Parse(input);
            //calculate celsius
            celsius = ((temp - 32) * 5) / 9;
            //Print out temp to screen 
            Console.WriteLine("The temp in Celsius is " + celsius);
        }

    }
}