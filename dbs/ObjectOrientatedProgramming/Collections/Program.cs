using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Collections
{
    class Program
    {
        static List<Employee> empList = new List<Employee>();
        static void Main(string[] args)
        {
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("*************Employee Management**********");
                Console.WriteLine("1: Add a new Employee");
                Console.WriteLine("2: Find an Employee");
                Console.WriteLine("3: Remove an Employee");
                Console.WriteLine("4: Show All Employees");
                Console.WriteLine("5: Quit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        EmployeeFound();
                        break;
                    case 3:
                        //RemoveEmployee();
                        break;
                    case 4:
                        ShowAllEmployees();
                        break;
                    case 5:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;

                }
            }

        }

        static bool CompareEmployee(Employee e)
        {
            bool found = false;

            foreach (Employee e1 in empList)
            {
                if(e.EmployeeID == e1.EmployeeID)
                {
                    found = true;
                }
            }
            return found;

        }

        static void AddEmployee()
        {
            Employee e = new Employee();

            Console.WriteLine("Please enter their ID");
            e.EmployeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter their first name");
            e.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter their surname");
            e.LastName = Console.ReadLine();

            Console.WriteLine("Please enter their wage");
            e.Wage = double.Parse(Console.ReadLine());

            if(!CompareEmployee(e))
            {
                empList.Add(e);
                Console.WriteLine("Employee has been added");
            }
            else
            {
                Console.WriteLine("Employee already exists");
            }

        }

        static void ShowAllEmployees()
        {
            foreach (Employee e in empList)
            {
                Console.WriteLine(e.ToString());
            }

        }

        static void EmployeeFound()
        {
            int id;

            Console.WriteLine("Please enter their ID");
            id = int.Parse(Console.ReadLine());
           
                foreach (Employee e in empList)
                {
                    if (e.EmployeeID == id)
                    {
                        Console.WriteLine("Employee Found, Details are:");
                        Console.WriteLine(e.ToString());
                        break;
                    }

                }
            }
            
        }

        //static void RemoveEmployee()
        //{
        //    int id;

        //    Console.WriteLine("Please enter employee ID");
        //    id = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < empList.Count; i++)
        //    {
        //        if (empList[i].EmployeeID == id)
        //        {
        //            empList.Remove(empList[i]);
        //        }
        //        else Console.WriteLine("Employee does not exist"); 
        //    }
        //}


    }

