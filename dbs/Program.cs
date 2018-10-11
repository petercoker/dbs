﻿using System;
using System.Collections.Generic;
using dbs.ObjectOrientatedProgramming.Inheritance;
using dbs.ObjectOrientatedProgramming.IntroductionToClasses;
using dbs.ObjectOrientatedProgramming.Collections;
using dbs.ObjectOrientatedProgramming.Interface.PassengerExample;
using dbs.ObjectOrientatedProgramming.Interface.TryFoodInterfaceExample;

using dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample;
using System.Collections;
using System.Collections.Generic;
using dbs.ObjectOrientatedProgramming.IntroductionToClasses.BookExample;

namespace dbs
{
    class Program
    {
        static List<TryBook> BookList = new List<TryBook>();
        static List<Employee> EmployeeList = new List<Employee>(); //It has to be outside of the main to be accessable through out the whole program class 
        static void Main(string[] args)
        {
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {

                Console.WriteLine("**************Book List*********");
                Console.WriteLine("1: Add a Book");
                Console.WriteLine("2: Remove a Book");
                Console.WriteLine("3: Display all Book");
                Console.WriteLine("4: To quit");

                Console.WriteLine();
                Console.Write("Please enter a number based on these options above: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        DisplayAllBook();
                        break;

                    case 4:
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }
            }
        }

        static bool CompareBook(TryBook book)
        {
            bool found = false;

            foreach (TryBook book1 in BookList)
            {
                if (book == book1)
                {
                    found = true;
                }
            }

            return found;
        }

        static void AddBook()
        {
            TryBook book = new TryBook();

            Console.Write("Pleae enter ISBN: ");
            book.ISBN = int.Parse(Console.ReadLine());

            Console.Write("Please enter Book Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Please name of Author of the Book: ");
            book.Author = Console.ReadLine();

            Console.Write("Please enter price of Book: ");
            book.Price = double.Parse(Console.ReadLine());

            if (!CompareBook(book))
            {
                BookList.Add(book);
                Console.WriteLine("Book has been added");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Book already exists");
            }
        }


        static void RemoveBook()
        {
            int iSBN;

            Console.Write("Please enter Book ISBN: ");
            iSBN = int.Parse(Console.ReadLine());

            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].ISBN == iSBN)
                {
                    BookList.Remove(BookList[i]);
                    Console.WriteLine("Book has been removed");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("No Book found");
                    break;
                }
            }
        }

        static void DisplayAllBook()
        {
            foreach (TryBook book in BookList)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine();
        }

    }
}