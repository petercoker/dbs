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
            return $"\nStudent ID: {StudentId}\nStudent Attendance: {IsCurrentStudent}\nStudent Name: {Name}\nStudent Status: {Status}\nStudent Phone: {Phone}\nStudent Email: {Email}\n";
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
            Students studentList = new Students();
            Student student = new Student();
            //int option;
            bool keepGoing = true, userOption = false; 
            string inputOption;

            //Students studentList = new Students();
            //Student student = new Student();
            //int option, studentStatus, phone, status, id;
            //bool softwarePageOption = false, keepGoing = true, userInputID = false, userInputStudentAttendance = false, userInputStatus = false, userInput = false, userInputName = false, userOption = false; ;
            //string studentName, name, email, studentAttendance, inputOption;
            //bool isCurrentStudent;
            while (keepGoing)
            {
                DBSMenus studentMenu = new DBSMenus();
                studentMenu.DisplayStudentMenu();

                //Start of Testing//

                Student student1 = new Student("Peter", 123, "peter@gmail.com", 1, true, StudentStatusEnum.Undergrad);
                Student student2 = new Student("James", 456, "James@gmail.com", 2, false, StudentStatusEnum.Postgrad);
                Student student3 = new Student("Sam", 789, "Sam@gmail.com", 3, false, StudentStatusEnum.Postgrad);
                Student student4 = new Student("Anne", 000, "Anne@gmail.com", 4, true, StudentStatusEnum.Undergrad);
                Student student5 = new Student("Rock", 111, "Rock@gmail.com", 5, true, StudentStatusEnum.Postgrad);
                Student student6 = new Student("Paper", 153, "Paper@gmail.com", 6, false, StudentStatusEnum.Undergrad);
                Student student7 = new Student("Water", 153, "Water@gmail.com", 7, false, StudentStatusEnum.Undergrad);

                studentList.Add(student1);
                studentList.Add(student2);
                studentList.Add(student3);
                studentList.Add(student4);
                studentList.Add(student5);
                studentList.Add(student6);
                studentList.Add(student7);

                //End of Tessting

                Console.WriteLine();

                while (!userOption)
                {
                    Console.Write("\nPlease enter a number listed by the menu above: ");
                    inputOption = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputOption))
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a number");
                        continue;
                    }

                    else if (int.TryParse(inputOption, out int option))
                    {
                        userOption = true;
                        lblStart:
                        switch (option)
                        {
                            case 1:
                                studentList.AddStudent();
                                break;

                            case 2:
                                studentList.ChangeAllStudentInfo();
                                break;

                            case 3:
                                studentList.ShowAllStudents();
                                break;

                            case 4:
                                studentList.ShowAllPostgradStudents();

                                //List<Student> postgradStudents = studentList.GetAllPostgradStudent();
                                //foreach (Student item in postgradStudents)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 5:
                                studentList.ShowAllUndergradStudents();
                                //Console.WriteLine("\nList of Students that are Undergrad Students of Dublin Business School\n");

                                //List<Student> undergradStudents = studentList.GetAllUndergradStudent();
                                //foreach (var item in undergradStudents)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 6:
                                studentList.ShowAllCurrentStudents();
                                break;

                            case 7:
                                studentList.ShowAllPostgradCurrentStudents();

                                //Console.WriteLine("\nList of all Students that are Postgrad Students and currently studying in Dublin Business School\n");

                                //List<Student> postgradCurrent = studentList.GetPostgradStudentCurrent();
                                //foreach (Student item in postgradCurrent)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 8:
                                studentList.ShowAllUndergradCurrentStudents();

                                //Console.WriteLine("\nList of all Students that are Undergrad Students and currently studying in Dublin Business School\n");

                                //List<Student> undergradCurrent = studentList.GetUndergradStudentCurrent();
                                //foreach (Student item in undergradCurrent)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 9:
                                studentList.ShowAllNotCurrentStudents();

                                //Console.WriteLine("\nList of all Students that are not currently studying in Dublin Business School\n");

                                //List<Student> allNotCurrentStudents = studentList.GetStudentNotCurrent();
                                //foreach (Student item in allNotCurrentStudents)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 10:
                                studentList.ShowAllPostgradNotCurrentStudents();

                                //Console.WriteLine("\nList of all Students that are Postgrad Students and not currently studying in Dublin Business School\n");

                                //List<Student> allNotCurrentPostgradStudents = studentList.GetPostgradStudentNotCurrent();
                                //foreach (Student item in allNotCurrentPostgradStudents)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 11:
                                studentList.ShowAllUndergradNotCurrentStudents();

                                //Console.WriteLine("\nList of all Students that are Undergrad Students and not currently studying in Dublin Business School\n");

                                //List<Student> allNotCurrentUndergradStudents = studentList.GetUndergradStudentNotCurrent();
                                //foreach (Student item in allNotCurrentUndergradStudents)
                                //{
                                //    Console.WriteLine(item.ToString());
                                //}
                                break;

                            case 12:
                                studentList.SortList();

                                //Console.WriteLine("\nList of Students sorted by Student ID");
                                //studentList.SortList();

                                //foreach (Student pupil in studentList)
                                //{
                                //    Console.Write($"\nStudent ID: {pupil.StudentId}\nStudent is a current Student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}\n");
                                //}
                                break;

                            case 13:
                                studentList.ShowAllTotalNumberStudents();

                                //Console.WriteLine($"\nThere are {studentList.Count} total number of Students in Dublin Business School");
                                break;

                            case 14:
                                studentList.FindStudent();
                                //while (!userInput)
                                //{
                                //    Console.Write("\nPlease enter the Student ID you wish to find: ");
                                //    id = int.Parse(Console.ReadLine());

                                //    if (!studentList.CheckUniqueID(id))
                                //    {
                                //        Console.WriteLine("\aStudent ID not found, this Student ID was not added into the Student Management");
                                //        continue;
                                //    }

                                //    else
                                //    {
                                //        Console.WriteLine(studentList.GetStudent(id).ToString());
                                //        userInput = true;
                                //    }
                                //}
                                break;

                            case 15:
                                studentList.DeleteStudent();

                                //Console.Write("\nPlease enter the Student ID you wish to delete: ");
                                //id = int.Parse(Console.ReadLine());

                                //Console.WriteLine(studentList.RemoveByID(id) ? $"\nThe Student with the ID of {id} has been removed" : "\nThere was no student with that ID in the list\a");

                                //Console.WriteLine();
                                //foreach (Student pupil in studentList)
                                //{
                                //    Console.WriteLine(pupil.ToString());
                                //}
                                break;

                            case 16:
                                studentList.Clear();
                                break;

                            case 17:
                                goto lblMainMenu;

                            default:
                                Console.WriteLine("\n\aThat is not an option");
                                continue;
                        }

                    }

                    else
                    {
                        Console.WriteLine("\n\aNot a number");
                        continue;
                    }
                }

                lblMainMenu:;
                DBSMenus dbsMenus = new DBSMenus();
                dbsMenus.GetMainMenu();
            }
        }
    }
}

