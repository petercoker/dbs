using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dbs.ObjectOrientatedProgramming.Lists.TryCourseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses courseList = new Courses();

            //HardCoding in the data
            //Course course1 = new Course(1, "IT", 8, false, 6);
            //Course course2 = new Course(2, "Business", 8, true, 7);
            //Course course3 = new Course(3, "Acccounting", 8, true, 8);

            //courseList.Add(course1);
            //courseList.Add(course2);
            //courseList.Add(course3);

            ////Creating a duplicate course and checking if it already exists or not
            //Course course4 = new Course(4, "Social Studies", 7, false, 9);

            //if (courseList.Contains(course4))
            //{
            //    courseList.Add(course4);
            //    Console.WriteLine("Item added");
            //}

            //else
            //{
            //    Console.WriteLine("Item already exists");
            //}

            //You can also get the user to enter the details
            Course course1 = new Course();
            Course course2 = new Course();

            Console.Write("Please enter the Course Code: ");
            course1.CourseCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the name of the course: ");
            course1.Name = Console.ReadLine();

            Console.Write("Please enter the course level: ");
            course1.Level = int.Parse(Console.ReadLine());

            courseList.Add(course1);
            Console.WriteLine($"Course Added");

            Console.Write("Please enter the Course Code: ");
            course2.CourseCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the name of the course: ");
            course2.Name = Console.ReadLine();

            Console.Write("Please enter the course level: ");
            course2.Level = int.Parse(Console.ReadLine());

            courseList.Add(course2);
            Console.WriteLine($"Course Added");

            //Printing out the number of items in the list
            Console.WriteLine($"There are {courseList.Count} number of courses");

            //Sorting the courses by Course Code
            Console.WriteLine();
            Console.WriteLine("Products Sorted by Course Code");
            courseList.SortList();

            foreach (Course course in courseList)
            {
                Console.WriteLine($"Course Code: {course.CourseCode}\nCourse Name: {course.Name}\nCourse Level: {course.Level}");
            }

            //Getting an Course Code from the user to delete a Course
            int courseCode;

            Console.WriteLine();
            Console.Write($"Enter the course code of the course you wish to delete: ");
            courseCode = int.Parse(Console.ReadLine());


            Console.WriteLine(courseList.GetCourse(courseCode).ToString());

            //Clear/empties the list
            courseList.Clear();
        }
    }
}
