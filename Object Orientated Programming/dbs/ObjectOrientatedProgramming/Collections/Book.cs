using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }


        public Book()
        {

        }

        public override string ToString()
        {
            return $"{Title} is written by {Author}\nIt costs {Price} and its ISBN is {ISBN}";
        }
    }
}
