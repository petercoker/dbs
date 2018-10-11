using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Collections
{
    class TryBook
    {
        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public TryBook()
        {
            
        }
        public TryBook(int iSBN, string title, string author, double price)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"Book ISBN: {ISBN}\nTitle of Book: {Title}\nAuthor of Book: {Author}\nPrice of Book: {Price}";
        }
    }

}