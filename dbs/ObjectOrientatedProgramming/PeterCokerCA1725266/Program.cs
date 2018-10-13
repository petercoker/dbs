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
            int option, id;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("\n*************Dublin Business School new management software package**********\n");
                Console.WriteLine("[Student Management]");
                Console.WriteLine("1: Add a new Student");
                Console.WriteLine("2: Find a Student by entering Student ID");
                Console.WriteLine("3: Delete a student by entering Student ID");
                Console.WriteLine("4: Show All Student"); 
                Console.WriteLine("5*: Show total number of students in Dublin Business School");
                Console.WriteLine(": Show All Current Students");
                Console.WriteLine(": Show total amount of Student");
                Console.WriteLine(": Clear all students in the student management system");
                Console.WriteLine(": Quit");

                Console.WriteLine();
                Console.WriteLine("[Teacher Management]");
                Console.WriteLine(": Add a new Student");
                Console.WriteLine(": Find a Student");
                Console.WriteLine(": Enter a Student ID to delete a student");
                Console.WriteLine(": Show All Student");
                Console.WriteLine(": Show All Current Students");
                Console.WriteLine(": Show total amount of Student");
                Console.WriteLine(": Quit");

                Console.WriteLine();
                Console.Write("Please enter a number listed by the menu above: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Student student = new Student();
                        int studentStatus;

                        Console.WriteLine();
                        Console.Write("Please enter your student ID: ");
                        student.StudentId = int.Parse(Console.ReadLine());

                        Console.Write("Please enter \"true\" or \"false\" if you are a current student: ");
                        student.IsCurrentStudent = bool.Parse(Console.ReadLine().ToLower());

                        Console.Write("Please enter your name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Please enter \"0\" for Undergrad or \"1\" for Postgrad: ");
                        studentStatus = int.Parse(Console.ReadLine());

                        Console.Write("Please enter your phone number: ");
                        student.Phone = int.Parse(Console.ReadLine());

                        Console.Write("Please enter your email: ");
                        student.Email = Console.ReadLine();

                        studentList.Add(student);

                        Console.WriteLine("\nData added to Student List");
                        break;

                    case 2:
                        Console.Write("\nPlease enter the Student ID you wish to find: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine(studentList.GetStudent(id).ToString());
                        break;

                    case 3:
                        Console.Write("\nPlease enter the Student ID you wish to delete: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine(studentList.RemoveByID(id) ? $"\nThe student with the ID of {id} has been removed" : "\nThere was no student with that ID in the list\a");
                        
                        Console.WriteLine();
                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine(pupil.ToString());
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n--All Student in the List--");
                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine(pupil.ToString());
                        }
                        break;


                    case 5: 
                        Console.WriteLine();
                        Console.WriteLine($"There are {studentList.Count} total number of students in Dublin Business School");
                        break;













                    case 90:
                        //Sort list of students by ID
                        //Console.WriteLine();
                        Console.WriteLine("Student in DBS sorted by Student ID");
                        studentList.SortList();

                        foreach (Student pupil in studentList)
                        {
                            Console.WriteLine($"Student ID: {pupil.StudentId}\nStudent is a current student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}");
                        }
                        break;
                    case 30:
                        //View list of current student studying in DBS
                        Console.WriteLine();
                        Console.WriteLine("List of student that are currently studying in Dublin Business School");

                        List<Student> currentStudentList = studentList.GetStudentCurrent();
                        foreach (var currentStudent in currentStudentList)
                        {
                            Console.WriteLine(currentStudent.ToString());
                        }
                        break;

                    case 70:
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

