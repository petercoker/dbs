using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetMenu();
        }

        public void GetMenu()
        {
            string managementOption;
            int option;
            bool keepGoing = false, userInputID = true;

            while (userInputID)
            {
                Console.WriteLine("\n*************Weclome to Dublin Business School new management software package**********");
                Console.WriteLine("1: To use the DBS Student Management System");
                Console.WriteLine("2: To use the DBS Teacher Management System");
                Console.WriteLine("3: Quit");

                Console.Write("\nPlease enter a number listed by the menu above: ");
                managementOption = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(managementOption))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(managementOption, out option))
                {
                    option = int.Parse(managementOption);
                    switch (option)
                    {
                        case 1:
                            Student studentManagementSystem = new Student();
                            studentManagementSystem.GetStudentManagementSystem();
                            break;
                        case 2:
                            Teacher TeacherManagementSystem = new Teacher();
                            TeacherManagementSystem.GetTeacherManagementSystem();
                            break;

                        case 3:
                            Console.WriteLine("\nThank you for using Dublin Business School management software package");
                            userInputID = false;
                            break;

                        default:
                            Console.WriteLine("\n\aThat is not an option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n\aNot a number");
                    continue;
                }
            }
        }
    }
}
