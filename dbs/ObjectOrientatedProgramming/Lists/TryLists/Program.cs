using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Lists.TryListsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Products list = new Products();

            Product product1 = new Product(8, "Chips", 3.50, true);
            Product product2 = new Product(5, "Donuts", 2.75, true);
            Product product3 = new Product(10, "Choc", .8, false);

            list.Add(product1);
            list.Add(product2);
            list.Add(product3);

            // Console.WriteLine($"There are {list.Count} itesm in the list");
            Console.WriteLine($"Products sorted by by price");
            list.SortList();

            foreach (Product item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("List of items in stock");
            List<Product> inStock = list.GetInStockItems();

            //Alterniate way of doing the statement above
            //List<Product> inStock2 = new List<Product>();
            //inStock2 = list.GetInStockItems();

            foreach (Product item in inStock)
            {
                Console.WriteLine(item.ToString());
            }

            int id;
            Console.WriteLine("Please enter ID of product you want");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(list.GetProduct(id).ToString());

            Console.WriteLine("Please enter ID of item you want to delete");
            id = int.Parse(Console.ReadLine()); //We are overriding int id or we can just create another

            if (list.RemoveByID(id))
            {
                Console.WriteLine($"Product with id of {id} was deleted");
            }

            else
            {
                Console.WriteLine($"The item was not in the list");
            }

        }
    }
}
