
using System;
using dbs.ObjectOrientatedProgramming.Collections;
using System.Collections.Generic;

///namespace dbs
//{
//    class OutputEmployee
//    {
//        static List<Employee> EmployeeList = new List<Employee>(); //It has to be outside of the main to be accessable through out the whole program class 
//        static void Main(string[] args)
//        {
//            int option;
//            bool keepGoing = true;

//            while (keepGoing)
//            {

//                Console.WriteLine("**************Employee Management*********");
//                Console.WriteLine("1: Add a new Employee");
//                Console.WriteLine("2: Find an Employee");
//                Console.WriteLine("3: Remove an Employee");
//                Console.WriteLine("4: Show all employees");
//                Console.WriteLine("5: Quit");

//                option = Convert.ToInt32(Console.ReadLine());

//                switch (option)
//                {
//                    case 1:
//                        AddEmployee();
//                        break;
//                    case 2:
//                        EmployeeFound(); 
//                        break;
//                    case 3:
//                        RemoveEmployee();
//                        break;
//                    case 4:
//                        ShowAllEmployee();
//                        break;

//                    case 5:
//                        keepGoing = false;
//                        break;

//                    default:
//                        Console.WriteLine("That is not an option");
//                        break;
//                }
//            }
//        }

//        static bool CompareEmployee(Employee employee)
//        {
//            bool found = false;

//            foreach (Employee employee1 in EmployeeList)
//            {
//                if(employee == employee1)
//                {
//                    found = true;
//                }
//            }

//            return found;
//        }

//        static void AddEmployee()
//        {
//            Employee employee = new Employee();

//            Console.WriteLine("Pleae enter their ID");
//            employee.EmployeeID = int.Parse(Console.ReadLine());

//            Console.WriteLine("Please enter thier first name");
//            employee.FirstName = Console.ReadLine();

//            Console.WriteLine("Please enter thier Last name");
//            employee.LastName = Console.ReadLine();

//            Console.WriteLine("Please enter thier wage");
//            employee.Wage = double.Parse(Console.ReadLine());

//            if (!CompareEmployee(employee))
//            {
//                EmployeeList.Add(employee);
//                Console.WriteLine("Empployee has been added");
//            } 
//            else
//            {
//                Console.WriteLine("Employee already exists");
//            }
//        }

//        static void ShowAllEmployee()
//        {
//            foreach (Employee employee in EmployeeList)
//            {
//                Console.WriteLine(employee.ToString());
//            }
//        }

//        static void EmployeeFound()
//        {
//            int iD;

//            Console.WriteLine("Please enter their ID");
//            iD = int.Parse(Console.ReadLine());

//            foreach(Employee employee1 in EmployeeList)
//            {
//                if (employee.EmployeeID == employee1.EmployeeID )
//                {
//                    Console.WriteLine("Employee Found, Details are: ");
//                    Console.WriteLine(employee.ToString());
//                }

//                else
//                {
//                    Console.WriteLine("Employee is not is the list");
//                }
//            }        }

//        static void RemoveEmployee()
//        {
//            int iD;

//            Console.WriteLine("Please enter employee ID");
//            iD = int.Parse(Console.ReadLine());

//            for (int i = 0; i < EmployeeList.Count; i++)
//            {
//                if (EmployeeList[i].EmployeeID == iD)
//                {
//                    EmployeeList.Remove(EmployeeList[i]);
//                }

//                else 
//                {
//                    Console.WriteLine("No Employee found");
//                }
//            }
//        }
//    }
//}

