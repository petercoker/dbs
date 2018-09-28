using System;

namespace dbs.IntroductionToClasses.BookExample
{
    class Book
    {
        ////Add to Main()
        //int amount;
        //Book book1 = new Book(12345, "Harry Potter", "JK Rowling", 1997, 12.50);

        //Console.WriteLine("The ISBN is " + book1.ISBN);
        //Console.WriteLine("The title is " + book1.Title);
        //Console.WriteLine("The Author is " + book1.Author);
        //Console.WriteLine("Year Published is " + book1.YearPublished);
        //Console.WriteLine("The price is " + book1.Price);

        //// Console.WriteLine("The total cost is " + book1.BulkBuying(10));
        ////Use the method with a user input
        //Console.WriteLine("How many did you buy?");
        //amount = int.Parse(Console.ReadLine());
        //Console.WriteLine("The total cost is " + book1.BulkBuying(amount));


        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public double Price { get; set; }

        public Book(int isbn, string title, string author, int yrpub, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            YearPublished = yrpub;
            Price = price;

        }

        public double BulkBuying(int noPurch)
        {
            return Price * noPurch;
        }

    }
}

