using System;
using System.Collections;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Teachers : ICollection<Teacher>
    {
        public List<Teacher> teacherList = new List<Teacher>();

        public int Count
        {
            get { return teacherList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Teacher item)
        {
            teacherList.Add(item);
        }

        public void Clear()
        {
            teacherList.Clear();
            Console.WriteLine($"\nTeacher List Cleared, there are {teacherList.Count} total number of Teachers in the DBS Student Management System");
        }

        public bool Contains(Teacher item)
        {
            return teacherList.Contains(item);
        }

        public void CopyTo(Teacher[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Teacher> GetEnumerator()
        {
            return teacherList.GetEnumerator();
        }

        public bool Remove(Teacher item)
        {
            return teacherList.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SortList()
        {
            if (!(teacherList.Count == 0))
            {
                Console.WriteLine("\nList of Teachers sorted by Employee ID");
                teacherList.Sort();

                foreach (Teacher staff in teacherList)
                {
                    Console.Write($"\nEmployee ID: {staff.EmployeeID}\nTeacher is current staff: {staff.IsCurrentEmployee}\nTeacher Name: {staff.Name}\nPhone: {staff.Phone}\nEmail: {staff.Email}\nTaught: {staff.Taught}\nSalary: ${staff.Salary}\n");
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Teacher present in Teacher managemnt system, please enter add neew Teacher into the Teacher management system");
            }
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = null;

            foreach (Teacher teachingStaff in teacherList)
            {
                if (teachingStaff.EmployeeID.Equals(id))
                {
                    teacher = teachingStaff;
                    break;
                }
            }

            return teacher;
        }

        public void DisplayTeacherMenu()
        {
            Console.WriteLine("\n[DBS Teacher Management System Menu]");
            Console.WriteLine("\nTeacher Management: Data definition options");
            Console.WriteLine("1: Add a new Teacher");

            Console.WriteLine("\nTeacher Management: Viewing options");
            Console.WriteLine("2: Show list of all Teachers in Dublin Business School");
            Console.WriteLine("3: Show list of all current Teachers in Dublin Business School");
            Console.WriteLine("4: Show list of all not current Teachers in Dublin Business School");
            Console.WriteLine("5: Show list of Teachers sorted by Employee ID");
            Console.WriteLine("6: Show total number of Teachers in Dublin Business School");

            Console.WriteLine("\nTeacher Management: Data manipulation options");
            Console.WriteLine("7: Find a Teacher by entering Employee ID");
            Console.WriteLine("8: Delete a Teacher by entering Employee ID");
            Console.WriteLine("9: Clear all Teachers in the Teacher management system");
            Console.WriteLine("10: Clear all Teachers in the Teacher management system & Go to Student Management System");
            Console.WriteLine("11: Quit application");
        }

        public void AddTeacher()
        {
            Teacher teacher = new Teacher();
            int teacherStatus, teacherPhone;
            double teacherSalary;
            bool userInputID = false, userInputTeacherStatus = false, userInputName = false, userInputTaught = false, userInputPhone = false, userInputEmail = false, userInputSalary = false, found = false;
            string inputTeacherID, inputTeacherTaught, inputTeacherEmail, inputTeacherName, inputTeacherPhone, inputAttendance, inputTeacherSalary;

            while (!userInputID)
            {
                Console.Write("\nPlease enter your Employee ID number (integer) with no spaces or enter \"q\" to go back to Teacher Menu: ");
                inputTeacherID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputTeacherID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputTeacherID == "q")
                {
                    Console.Clear();
                    GetTeacherManagementSystem();
                    userInputID = true;
                }

                else if (int.TryParse(inputTeacherID, out int id))
                {
                    if (id <= 0)
                    {
                        Console.WriteLine("\n\aPlease enter a postive number or that's is not 0");
                        continue;
                    }

                    else if (id >= 0)
                    {
                        Teacher checkNumber = GetTeacher(id);
                        
                        if (checkNumber != null)
                        {
                            found = true;
                            Console.WriteLine("\n\aTeacher already exists");
                            continue;
                        }

                        else
                        {
                            teacher.EmployeeID = id;
                            userInputID = true;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }

            while (!userInputTeacherStatus)
            {
                Console.Write("Please enter \"t\" for True or \"f\" for False if you are a current Staff: ");
                inputAttendance = Console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(inputAttendance))
                {
                    Console.WriteLine("\n\aInvalid input, please enter a string input");
                    continue;
                }

                else if (inputAttendance == "t")
                {
                    teacher.IsCurrentEmployee = true;
                    userInputTeacherStatus = true;
                }

                else if (inputAttendance == "f")
                {
                    teacher.IsCurrentEmployee = false;
                    userInputTeacherStatus = true;
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input, only enter \"t\" or \"f\" if you are a current Staff");
                    continue;
                }
            }

            while (!userInputName)
            {
                Console.Write("Please enter your name: ");
                inputTeacherName = Console.ReadLine();
                
                if (!(String.IsNullOrWhiteSpace(inputTeacherName)))
                {
                    if (!(int.TryParse(inputTeacherName, out int number)))
                    {
                        teacher.Name = inputTeacherName;
                        userInputName = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\ainvalid Input");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid input");
                    continue;
                }
            }

            while (!userInputTaught)
            {
                Console.Write("Please enter \"1\" if you taught Business and Management or \"2\" if you taught Computer science: ");
                inputTeacherTaught = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputTeacherTaught))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (int.TryParse(inputTeacherTaught, out teacherStatus))
                {
                    if (teacherStatus == 1)
                    {
                        teacher.Taught = TaughtEnum.BusinessAndManagement;
                        userInputTaught = true;
                    }

                    else if (teacherStatus == 2)
                    {
                        teacher.Taught = TaughtEnum.ComputerScience;
                        userInputTaught = true;
                    }
                    
                    else
                    {
                        Console.WriteLine("\n\aPlease only enter a number between \"1\" and \"2\" if you teach either Business and Management or Computer science");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }
            }

            while (!userInputPhone)
            {
                Console.Write("Please enter your 10 digit phone number (integer) with no spaces in between the number: ");
                inputTeacherPhone = Console.ReadLine();

                if (inputTeacherPhone.Length < 10 || inputTeacherPhone.Length > 10)
                {
                    Console.WriteLine("\n\aInvalid input, please enter 10 positive digit phone number");
                    continue;
                }

                else if (int.TryParse(inputTeacherPhone, out teacherPhone))
                {
                    if (teacherPhone < 0)
                    {
                        continue;
                    }

                    else
                    {
                        teacher.Phone = teacherPhone;
                        userInputPhone = true;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }

            while (!userInputEmail)
            {
                Console.Write("Please enter a valid email address that contains \"@\" and \".com\": ");
                inputTeacherEmail = Console.ReadLine();
                
                if (!(String.IsNullOrWhiteSpace(inputTeacherEmail)))
                {
                    if (inputTeacherEmail.Contains(".com") && inputTeacherEmail.Contains("@"))
                    {
                        teacher.Email = inputTeacherEmail;
                        userInputEmail = true;
                    }

                    else
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a valid email address");
                        continue;
                    }
               
                }
                
                else
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a string email");
                    continue;
                }
            }

            while (!userInputSalary)
            {
                Console.Write("Please enter your salary (double) with no spaces e.g 50.00: ");
                inputTeacherSalary = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputTeacherSalary))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (double.TryParse(inputTeacherSalary, out teacherSalary))
                {
                   
                   if (teacherSalary <= 0 || teacherSalary <= 0.00 || teacherSalary <= 0.0)
                    {
                        Console.WriteLine("\n\aPlease enter your salary, salary must not be null or  a positive number");
                        continue;
                    }

                    else
                    {
                        teacher.Salary = teacherSalary;
                        userInputSalary = true;
                    }
                }

                else
                {
                    Console.WriteLine("\n\aInvalid Input");
                    continue;
                }

            }

            teacherList.Add(teacher);
            Console.WriteLine("\nTeacher has been added");
        }

        public void ShowAllTeachers()
        {
            if (!(teacherList.Count == 0))
            {
                Console.WriteLine("\nAll Teachers in Dublin Business School");

                foreach (Teacher teacher in teacherList)
                {
                    Console.WriteLine(teacher.ToString());
                }
                
            }

            else
            {
                Console.WriteLine("\n\aNo Teacher present in Teacher managemnt system, please enter add neew Teacher into the Teacher management system");
            }
        }

        public void ShowAllCurrentTeachers()
        {
            if (!(teacherList.Count == 0))
            {
                Console.WriteLine("\nList of all Teachers that are currently working for Dublin Business School");

                List<Teacher> isCurrentTeacherList = new List<Teacher>();

                foreach (Teacher item in teacherList)
                {
                    if (item.IsCurrentEmployee == true)
                    {
                        isCurrentTeacherList.Add(item);
                    }
                }

                if (!(isCurrentTeacherList.Count == 0))
                {
                    foreach (Teacher item in isCurrentTeacherList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aNo Current Teacher present in Teacher managemnt system, please enter add Teacher into the Student management system");
                }

            }

            else
            {
                Console.WriteLine("\n\aNo Teacher present in Teacher managemnt system, please enter add neew Teacher into the Teacher management system");
            }
        }

        public void ShowAllNotCurrentTeachers()
        {
            if (!(teacherList.Count == 0))
            {
                Console.WriteLine("\nList of all Teachers that are not currently working for Dublin Business School");

                List<Teacher> isCurrentTeacherList = new List<Teacher>();

                foreach (Teacher item in teacherList)
                {
                    if (item.IsCurrentEmployee == false)
                    {
                        isCurrentTeacherList.Add(item);
                    }
                }

                if (!(isCurrentTeacherList.Count == 0))
                {
                    foreach (Teacher item in isCurrentTeacherList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                else
                {
                    Console.WriteLine("\n\aAll Teacher are working for DBS and present in Teacher managemnt system, please enter add Teacher into the Student management system");
                }
            }

            else
            {
                Console.WriteLine("\n\aNo Teacher present in Teacher managemnt system, please enter add neew Teacher into the Teacher management system");
            }
        }

        public void ShowAllTotalNumberTeachers()
        {
            Console.WriteLine($"\nThere are {teacherList.Count} total number of Teachers in Dublin Business School management system");
        }

        public void FindTeacher()
        {
            bool findInput = false, found = false;
            string inputID;
            Teacher teacher1 = new Teacher();

            while (!findInput)
            {
                Console.Write("\nPlease enter the Teacher's employee ID you wish to find with no spaces in between the numbers or enter \"q\" to go back to Teacher Menu: ");
                inputID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputID == "q")
                {
                    Console.Clear();
                    GetTeacherManagementSystem();
                    findInput = true;
                }

                else if (int.TryParse(inputID, out int id))
                {
                    foreach (Teacher teacher in teacherList)
                    {
                        if (teacher.EmployeeID == id)
                        {
                            teacher1 = teacher;
                            found = true;
                            findInput = true;
                        }

                    }

                    if (found)
                    {
                        Console.Write(teacher1.ToString());
                    }

                    else
                    {
                        Console.WriteLine("\a\nTeacher's employee ID not found, please add Teacher into Teacher Management System");
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

        public void DeleteTeacher()
        {
            Teacher teacher = new Teacher();
            bool deleteInput = false, removed = false;

            while (!deleteInput)
            {
                Console.Write("\nPlease enter the Teacher's Employee ID you wish to delete with no spaces in between the number or enter \"q\" to go back to Teacher Menu: ");
                string inputID = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputID))
                {
                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                    continue;
                }

                else if (inputID == "q")
                {
                    Console.Clear();
                    GetTeacherManagementSystem();
                    deleteInput = true;
                }

                else if (int.TryParse(inputID, out int id))
                {

                    for (int i = 0; i < teacherList.Count; i++)
                    {
                        if (teacherList[i].EmployeeID == id)
                        {
                            teacherList.Remove(teacherList[i]);
                            removed = true;
                        }

                    }

                    if (removed)
                    {
                        Console.WriteLine($"\nThe Teacher account number: {id} has been removed from the Teacher management system");

                        foreach (Teacher teachingStaff in teacherList)
                        {
                            Console.WriteLine(teachingStaff.ToString());
                        }

                        deleteInput = true;
                    }

                    else
                    {
                        Console.WriteLine("\a\nTeacher does exist, please add Teacher into Teacher Management System");
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
        
        public void GetTeacherManagementSystem()
        {
            Teacher teacher = new Teacher();
            Students student = new Students();
            bool keepGoing = true, userOption = true;
            string inputOption;

            while (keepGoing)
            {
                keepGoing = false;
                
                while (userOption)
                    {
                        DisplayTeacherMenu();

                        Console.Write("\nPlease enter a number listed by the menu above, with no spaces in between the number: ");
                        inputOption = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(inputOption))
                        {
                            Console.WriteLine("\n\aInvalid Input, please enter a number");
                            continue;
                        }

                        else if (int.TryParse(inputOption, out int option))
                        {
                            switch (option)
                            {
                                case 1:
                                    AddTeacher();
                                    break;

                                case 2:
                                    ShowAllTeachers();
                                    break;

                                case 3:
                                    ShowAllCurrentTeachers();
                                    break;

                                case 4:
                                    ShowAllNotCurrentTeachers();
                                    break;

                                case 5:
                                    SortList();
                                    break;

                                case 6:
                                    ShowAllTotalNumberTeachers();
                                    break;

                                case 7:
                                    FindTeacher();
                                    break;

                                case 8:
                                    DeleteTeacher();
                                    break;

                                case 9:
                                    Clear();
                                    break;

                                case 10:
                                    Console.Clear();
                                    student.GetStudentManagementSystem();
                                    break;

                                case 11:
                                    Console.Clear();
                                    Console.WriteLine("Thank you for using the Teacher management system");
                                    userOption = false;
                                    break;

                                default:
                                    Console.WriteLine("\n\aThat is not an option");
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


















    
}
