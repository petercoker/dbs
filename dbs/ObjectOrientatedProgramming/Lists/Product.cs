using System;

namespace dbs.ObjectOrientatedProgramming.Lists
{
    class Product: IComparable
    {
        public int ProductNo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }

        public Product()
        { }

        public Product(int id, string name, double price, bool inStock)
        {
            ProductNo = id;
            Name = name;
            Price = price;
            InStock = inStock;
        }

        public override string ToString()
        {
            return $"{ Name } costs {Price}";
        }

        //Implementing IComparable interface
        public int CompareTo(object other)
        {
            int sort = -1;
            Product prod = other as Product;
            if(other != null)
            {
                sort = this.Price.CompareTo(prod.Price);
            }
            return sort;
        }

        
    }
}
