using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Student : Person, IComparable
    {
        public int StudentId { get; set; }
        public bool IsCurrentStudent { get; set; }
        public StudentStatusEnum Status { get; set; }

        public Student()
        {

        }

        public Student(string name, int phone, string email, int studentId, bool isCurrentStudent, StudentStatusEnum status)
            : base(name, phone, email)
        {
            StudentId = studentId;
            IsCurrentStudent = isCurrentStudent;
            Status = status;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}\nIs Student a current Student: {IsCurrentStudent}\nStudent Name: {Name}\nStudent Status: {Status}\nnStudent Phone: {Phone}\nnStudent Email: {Email}\n";
        }

        public int CompareTo(object other)
        {
            int sort = -1;

            Student student = other as Student;

            if (other != null)
            {
                sort = this.StudentId.CompareTo(student.StudentId);
            }

            return sort;
        }

        public void GetStudentManagementSystem()
        {
            Students StudentList = new Students();
            Student student = new Student();
            int option, studentStatus, id, phone, status;
            bool softwarePageOption = false, keepGoing = true, userInputID = false, userInputStudentAttendance = false, userInputStatus = false, userInput = false, userInputName = false, userOption = false; ;
            string studentName, name, email, studentAttendance, inputOption;
            bool isCurrentStudent;

            while (keepGoing)
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

                Console.WriteLine();

                //Start of Testing//
                Student student1 = new Student("Peter", 123, "peter@gmail.com", 1, true, StudentStatusEnum.Undergrad);
                Student student2 = new Student("James", 456, "James@gmail.com", 2, false, StudentStatusEnum.Postgrad);
                //Student student3 = new Student("Sam", 789, "Sam@gmail.com", 3, false, StudentStatusEnum.Postgrad);
                //Student student4 = new Student("Anne", 000, "Anne@gmail.com", 4, true, StudentStatusEnum.Undergrad);
                //Student student5 = new Student("Rock", 111, "Rock@gmail.com", 5, true, StudentStatusEnum.Postgrad);
                //Student student6 = new Student("Paper", 153, "Paper@gmail.com", 6, false, StudentStatusEnum.Undergrad);
                //Student student7 = new Student("Water", 153, "Water@gmail.com", 7, false, StudentStatusEnum.Undergrad);

                StudentList.Add(student1);
                StudentList.Add(student2);
                //StudentList.Add(student3);
                //StudentList.Add(student4);
                //StudentList.Add(student5);
                //StudentList.Add(student6);
                //StudentList.Add(student7);
                //End of Tessting

                Console.WriteLine();

                while (!userOption)
                {
                    Console.Write("Please enter a number listed by the menu above: ");
                    inputOption = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputOption))
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a number");
                        continue;
                    }

                    userOption = true;

                    option = int.Parse(inputOption);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine();
                            userInput = false;

                            while (!userInputID)
                            {
                                Console.Write("Please enter your Student ID: ");
                                string input = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(input))
                                {
                                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                                    continue;
                                }

                                if (int.TryParse(input, out id))
                                {
                                    if (StudentList.CheckUniqueID(id))
                                    {
                                        Console.WriteLine("\n\aStudent ID already created, please enter unique Student ID number");
                                        continue;
                                    }

                                    else
                                    {
                                        student.StudentId = id;
                                        userInputID = true;
                                    }

                                }

                                else
                                {
                                    Console.WriteLine("\n\aNot a number");
                                    continue;
                                }


                            }

                            while (!userInputStudentAttendance)
                            {
                                Console.Write("Please enter \"t\" or \"f\" if you are a current Student: ");
                                studentAttendance = Console.ReadLine().ToLower();


                                if (studentAttendance == "t")
                                {
                                    student.IsCurrentStudent = true;
                                    userInputStudentAttendance = true;
                                }

                                else if (studentAttendance == "f")
                                {
                                    student.IsCurrentStudent = false;
                                    userInputStudentAttendance = true;
                                }

                                else
                                {
                                    Console.WriteLine("\n\aInvalid Input, only enter \"t\" or \"f\" if you are a current Student");
                                    continue;
                                }
                            }

                            while (!userInputName)
                            {
                                Console.Write("Please enter your name: ");
                                studentName = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(studentName))
                                {
                                    Console.WriteLine("\n\aInvalid Input, please enter a string input");
                                    continue;
                                }

                                else
                                {
                                    student.Name = studentName;
                                }

                            }

                            while (!userInputStatus)
                            {
                                Console.Write("Please enter \"0\" for Undergrad or \"1\" for Postgrad: ");
                                studentStatus = int.Parse(Console.ReadLine());

                                if (studentStatus == 0)
                                {
                                    student.Status = StudentStatusEnum.Undergrad;
                                    userInputStatus = true;
                                }

                                else if (studentStatus == 1)
                                {
                                    student.Status = StudentStatusEnum.Postgrad;
                                    userInputStatus = true;
                                }

                                else
                                {
                                    continue;
                                }
                            }


                            Console.Write("Please enter your phone number: ");
                            student.Phone = int.Parse(Console.ReadLine());

                            Console.Write("Please enter your email: ");
                            student.Email = Console.ReadLine();

                            StudentList.Add(student);

                            Console.WriteLine("\nData added to Student List");
                            break;

                        case 2://fix
                            while (!userInput)
                            {
                                Console.Write("\nPlease enter the Student ID you wish to find to change name: ");
                                id = int.Parse(Console.ReadLine());

                                if (!StudentList.CheckUniqueID(id))
                                {
                                    Console.WriteLine("\aStudent ID not found, this Student ID was not added into the Student Management");
                                    continue;
                                }

                                else
                                {
                                    Console.WriteLine(StudentList.GetStudent(id).ToString());

                                    Console.Write("Please enter \"true\" or \"false\" to change if you are a current Student: ");
                                    isCurrentStudent = bool.Parse(Console.ReadLine().ToLower());

                                    Console.Write("Please enter the Student's name you wish to change to: ");
                                    name = Console.ReadLine();

                                    Console.Write("Please enter \"0\" to change to Undergrad or \"1\" to change to Postgrad: ");
                                    status = int.Parse(Console.ReadLine());

                                    Console.Write("Please enter the phone number to change to: ");
                                    phone = int.Parse(Console.ReadLine());

                                    Console.Write("Please enter the email address to change to: ");
                                    email = Console.ReadLine();

                                    Console.WriteLine(StudentList.ChangeStudentInfo(id, isCurrentStudent, name, status, phone, email));

                                    //StudentList.Add(student);

                                    Console.WriteLine("\nStudent information Changed");
                                    Console.WriteLine(StudentList.GetStudent(id).ToString());

                                    userInput = true;
                                }
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nAll Students in Dublin Business School");
                            foreach (Student pupil in StudentList)
                            {
                                Console.WriteLine(pupil.ToString());
                            }
                            break;

                        case 4:
                            Console.WriteLine("\nList of Students that are Postgrad Students of Dublin Business School\n");

                            List<Student> postgradStudents = StudentList.GetAllPostgradStudent();
                            foreach (Student item in postgradStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 5:
                            Console.WriteLine("\nList of Students that are Undergrad Students of Dublin Business School\n");

                            List<Student> undergradStudents = StudentList.GetAllUndergradStudent();
                            foreach (var item in undergradStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 6:
                            Console.WriteLine("\nList of all Students that are currently studying in Dublin Business School\n");

                            List<Student> currentStudents = StudentList.GetStudentCurrent();
                            foreach (Student item in currentStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 7:
                            Console.WriteLine("\nList of all Students that are Postgrad Students and currently studying in Dublin Business School\n");

                            List<Student> postgradCurrent = StudentList.GetPostgradStudentCurrent();
                            foreach (Student item in postgradCurrent)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 8:
                            Console.WriteLine("\nList of all Students that are Undergrad Students and currently studying in Dublin Business School\n");

                            List<Student> undergradCurrent = StudentList.GetUndergradStudentCurrent();
                            foreach (Student item in undergradCurrent)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 9:
                            Console.WriteLine("\nList of all Students that are not currently studying in Dublin Business School\n");

                            List<Student> allNotCurrentStudents = StudentList.GetStudentNotCurrent();
                            foreach (Student item in allNotCurrentStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 10:
                            Console.WriteLine("\nList of all Students that are Postgrad Students and not currently studying in Dublin Business School\n");

                            List<Student> allNotCurrentPostgradStudents = StudentList.GetPostgradStudentNotCurrent();
                            foreach (Student item in allNotCurrentPostgradStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 11:
                            Console.WriteLine("\nList of all Students that are Undergrad Students and not currently studying in Dublin Business School\n");

                            List<Student> allNotCurrentUndergradStudents = StudentList.GetUndergradStudentNotCurrent();
                            foreach (Student item in allNotCurrentUndergradStudents)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;

                        case 12:
                            Console.WriteLine("\nList of Students sorted by Student ID");
                            StudentList.SortList();

                            foreach (Student pupil in StudentList)
                            {
                                Console.Write($"\nStudent ID: {pupil.StudentId}\nStudent is a current Student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}\n");
                            }
                            break;

                        case 13:
                            Console.WriteLine($"\nThere are {StudentList.Count} total number of Students in Dublin Business School");
                            break;

                        case 14:
                            while (!userInput)
                            {
                                Console.Write("\nPlease enter the Student ID you wish to find: ");
                                id = int.Parse(Console.ReadLine());

                                if (!StudentList.CheckUniqueID(id))
                                {
                                    Console.WriteLine("\aStudent ID not found, this Student ID was not added into the Student Management");
                                    continue;
                                }

                                else
                                {
                                    Console.WriteLine(StudentList.GetStudent(id).ToString());
                                    userInput = true;
                                }
                            }
                            break;

                        case 15:
                            Console.Write("\nPlease enter the Student ID you wish to delete: ");
                            id = int.Parse(Console.ReadLine());

                            Console.WriteLine(StudentList.RemoveByID(id) ? $"\nThe Student with the ID of {id} has been removed" : "\nThere was no student with that ID in the list\a");

                            Console.WriteLine();
                            foreach (Student pupil in StudentList)
                            {
                                Console.WriteLine(pupil.ToString());
                            }
                            break;

                        //case 16:
                        //    //Getting the count after an item has been deleted
                        //    Console.WriteLine(StudentList.Count);

                        //    Console.WriteLine("Look for ID");
                        //    id = int.Parse(Console.ReadLine());
                        //    Console.WriteLine(StudentList.GetStudent(id).ToString());
                        //    break;

                        case 17:
                            StudentList.Clear();
                            Console.WriteLine("Student List Cleared");
                            break;

                        case 18:
                            goto End;
                            break;

                        default:
                            Console.WriteLine("\n\aThat is not an option");
                            continue;
                    }
                }

                End:;
                Program program = new Program();
                program.GetMenu();
            }
        }
    }
}

