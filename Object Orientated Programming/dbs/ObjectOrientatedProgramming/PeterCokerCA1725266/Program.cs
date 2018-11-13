using System;
namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            Teachers teachers = new Teachers();
            bool userInput = false;
            string optionInput;

            Console.WriteLine("*****Weclome to Dublin Business School new management software package*****");

            while (!userInput)
            {
                Console.Write("\nPlease enter \"1\" if you are a Student or \"2\" if you are a Teacher or \"q\" to quite the program: ");
                optionInput = Console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(optionInput))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (optionInput == "q")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Dublin Business School management system");
                    userInput = true;
                }
                else if (int.TryParse(optionInput, out int option))
                {
                    if (option == 1)
                    {
                        Console.Clear();
                        students.GetStudentManagementSystem();
                        userInput = true;
                    }

                    else if (option == 2)
                    {
                        Console.Clear();
                        teachers.GetTeacherManagementSystem();
                        userInput = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\aPlease only enter a number between \"1\" and \"2\" if you are a Teacher or Student");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }
            }
            

        }
    }
}
