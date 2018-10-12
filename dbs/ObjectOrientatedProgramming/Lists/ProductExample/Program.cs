using System;
using System.Collections.Generic;

namespace dbs.ObjectOrientatedProgramming.Lists.ProductExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Products list = new Products();
            //HardCoding in the data
            Product product1 = new Product(8, "chips", 3.50, true);
            Product product2 = new Product(5, "Choc", .8, true);
            Product product3 = new Product(9, "Crisps", 1.5, false);
            //list.Add(product1);
            //list.Add(product2);
            //list.Add(product3);

            ////Creating a duplicate product and checking if it already exists or not
            //Product product4 = new Product(8, "chips", 3.50, true);
            //if (list.Contains(product4))
            //{
            //    list.Add(product4);
            //    Console.WriteLine("Item added");
            //}
            //else Console.WriteLine("Item already exists");

            //YOU CAN ALSO GET THE USER TO ENTER THE DETAILS

            Console.WriteLine("Please enter the porductID");
            product1.ProductNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter product name");
            product1.Name = Console.ReadLine();
            Console.WriteLine("Please enter the price");
            product1.Price = double.Parse(Console.ReadLine());

            list.Add(product1);

            Console.WriteLine("Please enter the porductID");
            product2.ProductNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter product name");
            product2.Name = Console.ReadLine();
            Console.WriteLine("Please enter the price");
            product2.Price = double.Parse(Console.ReadLine());
            list.Add(product2);


            //Printing out the number of items in the list
            Console.WriteLine($"There are {list.Count} products");

            //Sorting the items by price
            Console.WriteLine("Products Sorted by Price");
            list.SortList();

            foreach (var l in list)
            {
                Console.WriteLine($"{l.ProductNo} {l.Name} costs {l.Price}");
            }

            //Creating a list of items that are in stock and printing them to the screen
            Console.WriteLine("List of items that are in stock");
            List<Product> inStockItems = list.GetInStockItems();
            foreach (Product item in inStockItems)
            {
                Console.WriteLine(item.ToString());
            }

            //Getting an id from the user to delete an item
            int id;
            Console.WriteLine("Enter the product code of the item you wish to delete");
            id = int.Parse(Console.ReadLine());
            
            if (list.RemoveByID(id))
            {
                Console.WriteLine($"The product with the id of {id} has been removed");
            }
            else Console.WriteLine("The item was not in the list");


            //Printing out all items in the list after deleting an item
            foreach (var l in list)
            {
                Console.WriteLine(l.ToString());
            }
            //Getting the count after an item has been deleted
            Console.WriteLine(list.Count);

            Console.WriteLine("Look for ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine(list.GetProduct(id).ToString());

            //clears/empties the list
            list.Clear();

        }
    }
}
