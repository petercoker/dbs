using System;

namespace dbs.IntroductionToClasses.FilmExample
{
    class Film
    {
        ////Add to Main()

        //int days;

        //Film film = new Film("Harry Potter", "Fantasy", "Boy Wizard", 5.5, .1);

        //Console.WriteLine($"The films name is {film.Title} and the genre is {film.Genre}");
        //Console.WriteLine($"Films Description is {film.Description} and its price is {film.Cost}");

        //Console.WriteLine("How many days did you rent it for?");
        //days = int.Parse(Console.ReadLine());
        //Console.WriteLine($"The total cost is {film.TotalRental(days)}");


        //Console.WriteLine($"The VAT is {film.GetVat(film.TotalRental(days))}");

        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public double VAT { get; set; }

        public Film(string title, string genre, string desc, double cost, double vat)
        {
            Title = title;
            Genre = genre;
            Description = desc;
            Cost = cost;
            VAT = vat;
        }

        public double TotalRental(int days)
        {
            return Cost * days;
        }

        public double GetVat(double total)
        {
            return total * VAT;
        }

    }
}


