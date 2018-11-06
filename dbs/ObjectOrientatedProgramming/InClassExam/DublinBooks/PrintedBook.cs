namespace dbs.ObjectOrientatedProgramming.InClassExam.DublinBooks
{
    class PrintedBook : Book
    {
        public int NumberOfPage { get; set; }
        public double Weight { get; set; }

        public PrintedBook()
        {

        }

        public PrintedBook(string title, string author, int pusblishedYear, int isbn, double netPrice, int numberOfPage, double weight)
            : base(title, author, pusblishedYear, isbn, netPrice)
        {
            NumberOfPage = numberOfPage;
            Weight = weight;
        }

        public override double GetGrossPrice()
        {
            double sum = (NetPrice / 100 * 15) + NetPrice;
            return sum;
        }
    }

}
