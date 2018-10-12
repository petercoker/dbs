using System;

namespace dbs.ObjectOrientatedProgramming.Lists.TryProductExample
{
    public class Product : IComparable
    {
        public int ProductNo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, double price, bool inStock)
        {
            ProductNo = id;
            Name = name;
            Price = price;
            InStock = inStock;
        }

        public override string ToString()
        {
            return $"{ProductNo} and it's called{Name} has a price of {Price}";
        }

        //The first item on the 
        public int CompareTo(object other) //Object is non defined. object just see values...//You can use Product instead of Object
        {
            int sort = 0;//You can use these as an alternative  int sort = 1 or int sort = 0...sort is like a place holder to sort 

            Product product = other as Product;

            if (other != null) //
            {
                sort = this.Price.CompareTo(product.Price); //This keyword deals with what we are dealing with at the moment e.g obj
            }

            return sort; //sort 0 was something the use to return a value it could be 0, 1, -1 it just need to be a number
        }
    }
}
