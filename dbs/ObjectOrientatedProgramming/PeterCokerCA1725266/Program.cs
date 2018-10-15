using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Program
    {
        static void Main(string[] args)
        {
            Students StudentList = new Students();
            Student student = new Student();
            int option, studentStatus, id;
            bool keepGoing = true;

            Student student1 = new Student("Peter", 123, "peter@gmail.com", 1, true, StudentStatusEnum.Undergrad);
            Student student2 = new Student("James", 456, "James@gmail.com", 2, false, StudentStatusEnum.Postgrad);
            Student student3 = new Student("Sam", 789, "Sam@gmail.com", 3, false, StudentStatusEnum.Postgrad);
            Student student4 = new Student("Anne", 000, "Anne@gmail.com", 4, true, StudentStatusEnum.Undergrad);
            Student student5 = new Student("Rock", 111, "Rock@gmail.com", 5, true, StudentStatusEnum.Postgrad);

            StudentList.Add(student1);
            StudentList.Add(student2);
            StudentList.Add(student3);
            StudentList.Add(student4);
            StudentList.Add(student5);

            List<Student> currentStudent = StudentList.GetStudentCurrent();
            foreach (var item in currentStudent)
            {
                Console.WriteLine(item.ToString());
            }
            //Console.WriteLine(StudentList.ToString());

            //Console.WriteLine("\nList of student that are currently studying in Dublin Business School");
            //List<Student> currentStudentList = StudentList.GetStudentCurrent();
            //foreach (Student currentStudent in currentStudentList)
            //{
            //    Console.WriteLine(currentStudent.ToString());
            //}

            //while (keepGoing)
            //{
            //    Console.WriteLine("\n*************Dublin Business School new management software package**********\n");
            //    Console.WriteLine("[Student Management]");
            //    Console.WriteLine("1: Add a new Student");
            //    Console.WriteLine("2: Find a Student by entering Student ID");
            //    Console.WriteLine("3: Delete a student by entering Student ID");
            //    Console.WriteLine("4: Show list of All Students in Dublin Business School");
            //    Console.WriteLine("5: Show total number of Students in Dublin Business School");
            //    Console.WriteLine("6*: Show list of All Current Students");
            //    Console.WriteLine("7: Sort list of students by ID");
            //    Console.WriteLine("8**: Get the total number of Students");// Getting the count after an item has been deleted
            //    Console.WriteLine("9: Clear all students in the student management system");
            //    Console.WriteLine("10: Quit");

            //    Console.WriteLine();
            //    Console.WriteLine("[Teacher Management]");
            //    Console.WriteLine(": Add a new Student");
            //    Console.WriteLine(": Find a Student");
            //    Console.WriteLine(": Enter a Student ID to delete a student");
            //    Console.WriteLine(": Show All Student");
            //    Console.WriteLine(": Show All Current Students");
            //    Console.WriteLine(": Show total amount of Student");
            //    Console.WriteLine(": Quit");

            //    Console.WriteLine();
            //    Console.Write("Please enter a number listed by the menu above: ");
            //    option = int.Parse(Console.ReadLine());

            //    switch (option)
            //    {
            //        case 1:
            //            Student student1 = new Student("Peter", 123, "peter@gmail.com", 1, true, StudentStatusEnum.Undergrad);
            //            Student student2 = new Student("James", 456, "James@gmail.com", 2, false, StudentStatusEnum.Postgrad);
            //            Student student3 = new Student("Sam", 789, "Sam@gmail.com", 3, false, StudentStatusEnum.Postgrad);
            //            Student student4 = new Student("Anne", 000, "Anne@gmail.com", 4, true, StudentStatusEnum.Undergrad);
            //            Student student5 = new Student("Rock", 111, "Rock@gmail.com", 5, true, StudentStatusEnum.Postgrad);
            //            StudentList.Add(student1);
            //            StudentList.Add(student2);
            //            StudentList.Add(student3);
            //            StudentList.Add(student4);
            //            StudentList.Add(student5);
            //            break;

            //            //Console.WriteLine();
            //            //Console.Write("Please enter your Student ID: ");
            //            //student.StudentId = int.Parse(Console.ReadLine());

            //            //Console.Write("Please enter \"true\" or \"false\" if you are a current Student: ");
            //            //student.IsCurrentStudent = bool.Parse(Console.ReadLine().ToLower());

            //            //Console.Write("Please enter your name: ");
            //            //student.Name = Console.ReadLine();

            //            //Console.Write("Please enter \"0\" for Undergrad or \"1\" for Postgrad: ");
            //            //studentStatus = int.Parse(Console.ReadLine());

            //            //if (studentStatus == 0)
            //            //{
            //            //    student.Status = StudentStatusEnum.Undergrad;
            //            //}

            //            //else if (studentStatus == 1)
            //            //{
            //            //    student.Status = StudentStatusEnum.Postgrad;
            //            //}

            //            //Console.Write("Please enter your phone number: ");
            //            //student.Phone = int.Parse(Console.ReadLine());

            //            //Console.Write("Please enter your email: ");
            //            //student.Email = Console.ReadLine();

            //            //StudentList.Add(student);

            //            //Console.WriteLine("\nData added to Student List");
            //            //break;

            //        case 2: 
            //            Console.Write("\nPlease enter the Student ID you wish to find: ");
            //            id = int.Parse(Console.ReadLine());

            //            if (!(student.StudentId == id))
            //            {
            //                Console.WriteLine("\aStudent ID not found, please add a Student by enter 1'st option");
            //                break;
            //            }

            //            else
            //            {
            //                Console.WriteLine(StudentList.GetStudent(id).ToString());
            //            }

            //            break;
            //        case 3:
            //            Console.Write("\nPlease enter the Student ID you wish to delete: ");
            //            id = int.Parse(Console.ReadLine());

            //            Console.WriteLine(StudentList.RemoveByID(id) ? $"\nThe Student with the ID of {id} has been removed" : "\nThere was no student with that ID in the list\a");

            //            Console.WriteLine();
            //            foreach (Student pupil in StudentList)
            //            {
            //                Console.WriteLine(pupil.ToString());
            //            }
            //            break;

            //        case 4:
            //            Console.WriteLine("\nAll Student in the List");
            //            foreach (Student pupil in StudentList)
            //            {
            //                Console.WriteLine(pupil.ToString());
            //            }
            //            break;

            //        case 5:
            //            Console.WriteLine($"\nThere are {StudentList.Count} total number of Students in Dublin Business School");
            //            break;

            //        //case 6: //Fix issue
            //        //    Console.WriteLine("\nList of student that are currently studying in Dublin Business School");

            //        //    List<Student> currentStudentList = StudentList.GetStudentCurrent();
            //        //    foreach (Student currentStudent in currentStudentList)
            //        //    {
            //        //        Console.WriteLine(currentStudent.Equals(true).ToString());
            //        //    }
            //        //    break;

            //        //    Console.WriteLine("List of items that are in stock");
            //        //    List<Product> inStockItems = list.GetInStockItems();
            //        //    foreach (Product item in inStockItems)
            //        //    {
            //        //        Console.WriteLine(item.ToString());
            //        //    }

            //        case 6: //Fix issue
            //            Console.WriteLine("\nList of Student that are currently studying in Dublin Business School");

            //            List<Student> currentStudentList = StudentList.GetStudentCurrent();
            //            foreach (Student currentStudent in currentStudentList)
            //            {
            //                Console.WriteLine(currentStudent.ToString());
            //            }
            //            break;

            //        case 7:
            //            Console.WriteLine("\nList of Students sorted by Student ID");
            //            StudentList.SortList();

            //            foreach (Student pupil in StudentList)
            //            {
            //                Console.Write($"\nStudent ID: {pupil.StudentId}\nStudent is a current Student: {pupil.IsCurrentStudent}\nStudent: {pupil.Name}\nStatus: {pupil.Status}\nPhone: {pupil.Phone}\nEmail: {pupil.Email}\n");
            //            }
            //            break;

            //        //case 8:
            //        //    //Getting the count after an item has been deleted
            //        //    Console.WriteLine(StudentList.Count);

            //        //    Console.WriteLine("Look for ID");
            //        //    id = int.Parse(Console.ReadLine());
            //        //    Console.WriteLine(StudentList.GetStudent(id).ToString());
            //        //    break;
            //        case 9:
            //            StudentList.Clear();
            //            break;
            //        case 10:
            //            keepGoing = false;
            //            break;
            //        default:
            //            Console.WriteLine("That is not an option");
            //            break;
            //    }

            //}

        }


    }
}

