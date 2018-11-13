using System;

namespace dbs.ObjectOrientatedProgramming.RecapExercises
{
    class ex10
    {
        public void CheckPinForLoop()
        {
            string input;
            int correctPin = 1234;
            int userPin;

            for (int goes = 0; goes < 3; goes++)
            {
                Console.WriteLine("Enter pin");
                input = Console.ReadLine();
                userPin = int.Parse(input);

                if (userPin == correctPin)
                {
                    Console.WriteLine("Correct Pin");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pin");
                }
            }
            Console.WriteLine("Goodbye");

        }
    }
}
