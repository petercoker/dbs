using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Program
    {
        static void Main(string[] args)
        {
            Students studentList = new Students();
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("*************Dublin Business School new management software package**********");
                Console.WriteLine("Student Management");
                Console.WriteLine(": Add a new Student");
                Console.WriteLine(": Find a Student");
                Console.WriteLine(": Enter a Student ID to delete a student");
                Console.WriteLine(": Show All Student");
                Console.WriteLine(": Show All Current Students");
                Console.WriteLine(": Show total amount of Student");
                Console.WriteLine(": Clear all students in the student management system");
                Console.WriteLine(": Quit");

                Console.WriteLine();
                Console.WriteLine("Teacher Management");
                Console.WriteLine("8: Add a new Student");
                Console.WriteLine("9: Find a Student");
                Console.WriteLine("10: Enter a Student ID to delete a student");
                Console.WriteLine("11: Show All Student");
                Console.WriteLine("12: Show All Current Students");
                Console.WriteLine("13: Show total amount of Student");
                Console.WriteLine("14: Quit");

                Console.WriteLine();
                Console.Write("Enter a option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //Add student
                        Student student = new Student();
                        int status;

                        Console.WriteLine();
                        Console.Write("Enter student ID: ");
                        student.StudentId = int.Parse(Console.ReadLine());

                        Console.Write("Enter \"true\" or \"false\" if you a current student: ");
                        student.IsCurrentStudent = bool.Parse(Console.ReadLine().ToLower());

                        Console.Write("Enter your name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Enter if you are Postgrad enter \"1\" or Undergrad enter \"0\": ");
                        status = int.Parse(Console.ReadLine());

                        int underGrad = 0, postGrad = 1;

                        if (status == 0)
                        {
                            student.Status = StudentStatusEnum.Undergrad;
                        }

                        else if (status == 1)
                        {
                            student.Status = StudentStatusEnum.Postgrad;
                        }

                        else
                        {
                            Console.Write("Please either enter 1 or 0: ");
                            status = int.Parse(Console.ReadLine());
                        }

                        Console.Write("Enter your phone number: ");
                        student.Phone = int.Parse(Console.ReadLine());

                        Console.Write("Enter your email: ");
                        student.Email = Console.ReadLine();

                        studentList.Add(student);
                        Console.WriteLine("Added to Student List");
                        Console.WriteLine();
                        break;

                    case 2:
                        //Sort list of students by ID
                        //Console.WriteLine();
                        Console.WriteLine("Student in DBS sorted by Student ID");
                        studentList.SortList();

                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine($"Student ID: {pupil.StudentId}\nStudent is a current student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}");
                        }
                        break;
                    case 3:
                        //View list of current student studying in DBS
                        Console.WriteLine();
                        Console.WriteLine("List of student that are currently studying in Dublin Business School");

                        List<Student> currentStudentList = studentList.GetStudentCurrent();
                        foreach (var currentStudent in currentStudentList)
                        {
                            Console.WriteLine(currentStudent.ToString());
                        }
                        break;
                    case 4:
                        //View Total number of students
                        Console.WriteLine();
                        Console.WriteLine($"There are {studentList.Count} total number of student in Dublin Business");
                        break;
                    case 5:
                        //Getting an id from the user to delete an item
                        int id;
                        Console.WriteLine();
                        Console.WriteLine("Enter the Student ID you wish to delete");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine(studentList.RemoveByID(id) ? $"The student with the ID of {id} has been removed" : "The student with the ID was not in the list");

                        //Printing out all items in the list after deleting an item
                        Console.WriteLine();
                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine(pupil.ToString());
                        }
                        break;
                    case 6:
                        //Printing out all items in the list
                        Console.WriteLine();
                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine(pupil.ToString());
                        }
                        break;

                    case 7:
                        //Getting the count after an item has been deleted
                        Console.WriteLine(studentList.Count);

                        Console.WriteLine("Look for ID");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(studentList.GetStudent(id).ToString());
                        break;
                    case 8:
                        //clears/empties the list
                        studentList.Clear();
                        break;
                    case 9:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }

            }

        }


    }
}

