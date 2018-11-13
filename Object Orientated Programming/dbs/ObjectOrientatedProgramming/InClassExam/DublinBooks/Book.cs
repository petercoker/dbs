using System;
using System.Collections.Generic;
using System.Text;

namespace dbs.ObjectOrientatedProgramming.InClassExam.DublinBooks
{
    abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }

        public int ISBN { get; set; }

        public double NetPrice { get; set; }

        public Book()
        {

        }


        public Book(string title, string author, int pusblishedYear, int isbn, double netPrice)
        {
            Title = title;
            Author = author;
            PublishedYear = pusblishedYear;
            ISBN = isbn;
            NetPrice = netPrice;
        }

        abstract public double GetGrossPrice();

    }
}
