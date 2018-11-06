using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex7
    {
        public void CheckDaysOfWeek()
        {
            bool isWeekend = false;

            if (isWeekend)
            {
                Console.WriteLine("Have a lie on");
            }
            else
            {
                Console.WriteLine("Set alarm for 7.30 am");
            }
            Console.WriteLine(isWeekend == true ? "Have a lie on" : "Set alarm for 7.30 am");
        }

    }
}