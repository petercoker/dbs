using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Collections
{
    class OutputTryBook
    {
        static List<TryBook>
            BookList =
                new List<TryBook>(); //It has to be outside of the main to be accessable through out the whole program class 

        static void Main(string[] args)
        {
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {

                Console.WriteLine("**************Book List*********");
                Console.WriteLine("1: Add a Book");
                Console.WriteLine("2: Remove a Book");
                Console.WriteLine("3: Find a book");
                Console.WriteLine("4: Display all Book");
                Console.WriteLine("5: To quit");

                Console.WriteLine();
                Console.Write("Please enter a number based on these options above: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        Console.WriteLine(RemoveBook());
                        //RemoveBook();
                        break;

                    case 3:
                        Console.WriteLine(BookFound());
                        //BookFound();
                        break;
                    case 4:
                        DisplayAllBook();
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

        static bool CompareBook(TryBook book)
        {
            bool found = false;

            foreach (TryBook book1 in BookList)
            {
                if (book.ISBN == book1.ISBN)
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


        static string RemoveBook()
        {
            int iSBN;
            bool removed = false;

            Console.Write("Please enter Book ISBN: ");
            iSBN = int.Parse(Console.ReadLine());

            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].ISBN == iSBN)
                {
                    BookList.Remove(BookList[i]);
                    removed = true;
                }
            }

            if (removed)
            {
                return "Book has been removed";
            }

            else
            {
                return "The Book did not exist";
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

        static string BookFound()
        {
            int isbn;
            bool found = false;
            TryBook book1 = new TryBook();

            Console.Write("Please enter book ISBN: ");
            isbn = Convert.ToInt32(Console.ReadLine());

            foreach (TryBook book in BookList)
            {
                if (book.ISBN == isbn)
                {
                    book1 = book;
                    found = true;
                }
            }

            if (found)
            {
                return book1.ToString();
            }
            else
            {
                return "Book not found";
            }
        }


    }
}
