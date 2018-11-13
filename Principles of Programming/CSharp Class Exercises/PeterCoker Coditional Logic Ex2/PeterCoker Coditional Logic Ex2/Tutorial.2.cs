using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Tutorial
    {
        static void Main(string[] args)    
        {
            string[] names = {"Cheryl", "Joe", "Matt", "Robert"};

            foreach (string person in names)
             {
                Console.WriteLine("{0}", person);
            }
            /*
            for (int i = 0; i < 20; i++)
            {
                if (i == 30)
                    break;

                if (i * 2 == 0)
                    continue;
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
            */

            /*Console.WriteLine($"What\x hh up");


            /* Console.WriteLine("Enter your age name please ");
            Console.WriteLine("Enter your brother name please ");
            Console.WriteLine("Enter your friend name pleasee    ");

            string name = Console.ReadLine();
            string age = Console.ReadLine();
            string brother = Console.ReadLine();
            string friend = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("Welcome Hokage:{0}\nYour age is {1}\nYour brother is {2}\nYour friend is{3} ", name, age, brother,friend);
           */
            
            /*
            string myChoice;

            do

            {
                Console.WriteLine("My Address Book\n");

                Console.WriteLine("\nA - Add New Address");
                Console.WriteLine("D - Add Delete Address");
                Console.WriteLine("M - Add Modify Address");
                Console.WriteLine("V - Add View Address");
                Console.WriteLine("Q - Add Quit\n");
                

                Console.WriteLine("Choice (A,D,M,V, or Q): ");

                myChoice = Console.ReadLine();

                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("You wish to add an address");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("You wish to delete an address");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("You wish to modify an address");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("You wish to view the address list");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;



                }

                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();

            } while (myChoice != "Q" && myChoice != "q");
            */
            /*
            int myint = 0;

            while (myint < 10)
            {
                Console.Write("{0}", myint);
                myint++;
            }
            */

            Console.ReadLine();
        }
    }
}
