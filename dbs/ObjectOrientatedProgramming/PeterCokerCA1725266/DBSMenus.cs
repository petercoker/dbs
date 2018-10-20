using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class DBSMenus
    {
        public void DisplayStudentMenu()
        {
            Console.WriteLine("\n[DBS Student Management System Menu]");
            Console.WriteLine("\nStudent Management: Data definition options");
            Console.WriteLine("1: Add a new Student");
            Console.WriteLine("2*: Change data of a Student by finding ID and editing the rest of the data");

            Console.WriteLine("\nStudent Management: Viewing options");
            Console.WriteLine("3: Show list of all Students in Dublin Business School");
            Console.WriteLine("4: Show list of all Postgrad Students");
            Console.WriteLine("5: Show list of all Undergrad Students");
            Console.WriteLine("6: Show list of all Current Students");
            Console.WriteLine("7: Show list of all Postgrad Students currently in Dublin Business School");
            Console.WriteLine("8: Show list of all Undergrad Students currently in Dublin Business School");
            Console.WriteLine("9: Show list of all Not Current Students");
            Console.WriteLine("10: Show list of all Postgrad Students not currently in Dublin Business School");
            Console.WriteLine("11: Show list of all Undergrad Students not currently in Dublin Business School");
            Console.WriteLine("12: Show list of Students by ID");
            Console.WriteLine("13: Show total number of Students in Dublin Business School");

            Console.WriteLine("\nStudent Management: Data manipulation options");
            Console.WriteLine("14**: Find a Student by entering Student ID"); //Fix issue only allow you to use the find once
            Console.WriteLine("15: Delete a Student by entering Student ID");
            Console.WriteLine("16: Clear all Students in the Student management system");
            Console.WriteLine("17: Quit");
        }

        public void DisplayTeacherMenu()
        {
        }

        public void DisplayMainMain()
        {
            Console.WriteLine("\n*************Weclome to Dublin Business School new management software package**********");
            Console.WriteLine("1: To use the DBS Student Management System");
            Console.WriteLine("2: To use the DBS Teacher Management System");
            Console.WriteLine("3: Quit");

            Console.Write("\nPlease enter a number listed by the menu above: ");
        }

        public void GetMainMenu()
        {
            string managementOption;
            int option;
            bool userInputID = true;

            while (userInputID)
            {
                DBSMenus mainMenu = new DBSMenus();
                mainMenu.DisplayMainMain();

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
                            Console.Clear();
                            Student studentManagementSystem = new Student();
                            studentManagementSystem.GetStudentManagementSystem();
                            break;
                        case 2:
                            Console.Clear();
                            Teachers TeacherManagementSystem = new Teachers();
                            TeacherManagementSystem.GetTeacherManagementSystem();
                            break;

                        case 3:
                            Console.Clear();
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
