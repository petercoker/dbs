using System;

namespace dbs.ObjectOrientatedProgramming.InClassExam.DublinBooks
{
    class eBook : Book
    {
        public double FileSize { get; set; }

        public eBook()
        {

        }

        public eBook(string title, string author, int pusblishedYear, int isbn, double netPrice, double fileSize)
            : base(title, author, pusblishedYear, isbn, netPrice)
        {
            FileSize = fileSize;
        }

        public override double GetGrossPrice()
        {
            double sum = (NetPrice / 100 * 5) + NetPrice;
            return sum;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPusblished Year: {PublishedYear}\nISBN: {ISBN}\nNetPrice {NetPrice}\nFile Size in kilobytes: {FileSize}";
        }
    }
}
