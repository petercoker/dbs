using System;
using System.Collections.Generic;

namespace BookExample
{
    class Program
    {
        static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("*************Book Management**********");
                Console.WriteLine("1: Add a new Book");
                Console.WriteLine("2: Find an Book");
                Console.WriteLine("3: Remove an Book");
                Console.WriteLine("4: Show All Books");
                Console.WriteLine("5: Quit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        Console.WriteLine(BookFound()); 
                        break;
                    case 3:
                        Console.WriteLine(RemoveBook());
                        break;
                    case 4:
                        ShowAllBooks();
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
        static bool CompareBook(Book b1)
        {
            bool found = false;

            foreach (Book b in books)
            {
                if (b.ISBN == b1.ISBN)
                {
                    found = true;
                }
            }
            return found;

        }

        static void AddBook()
        {
            Book b = new Book();

            Console.WriteLine("Please enter the ISBN");
            b.ISBN = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Title");
            b.Title = Console.ReadLine();

            Console.WriteLine("Please enter the Author");
            b.Author = Console.ReadLine();

            Console.WriteLine("Please enter th Price");
            b.Price = double.Parse(Console.ReadLine());

            if (!CompareBook(b))
            {
                books.Add(b);
                Console.WriteLine("Book has been added");
            }
            else
            {
                Console.WriteLine("Book already exists");
            }

        }

        static void ShowAllBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }

        }

        static string BookFound()
        {
            int isbn;
            bool found = false;
            Book b1 = new Book();

            Console.WriteLine("Please enter their ID");
            isbn = int.Parse(Console.ReadLine());

            foreach (Book b in books)
            {
                if (b.ISBN == isbn)
                {
                    b1 = b;
                    found = true;
                }

            }
            if (found)
            {
                return b1.ToString();
            }
            else return "Book not found";
        }



        static string RemoveBook()
        {
            int isbn;
            bool removed = false;

            Console.WriteLine("Please enter Book ID");
            isbn = int.Parse(Console.ReadLine());

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    books.Remove(books[i]);
                    removed= true;
                }
            }
            if (removed)
            {
                return "The book was removed";
            }
            else return "The book did not exist";

        }
    }
}
