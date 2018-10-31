using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q7
    {
        static void Main(string[] args)
        {
            //declare 
           
            int input, num1, num2, result;
            
            
            
            
            
           //Prompt user
           Console.WriteLine("Welcome to the SimpleCacl");
            
            Console.WriteLine("\nPress 1 to add two numbers");
            Console.WriteLine("\nPress 2 to subract two numbers");
            Console.WriteLine("\nPress 3 to divide two numbers");
            Console.WriteLine("\nPress 4 to multiple two numbers");
            Console.Write("\nPlease press a number between 1 and 4: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.Write("Enter first number ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 + num2;

                Console.Write("Result is {0}", result);

            }

            else if (input == 2)
            {
                Console.Write("Enter first number ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 - num2;

                Console.Write("Result is {0}", result);
            }

            else if (input == 3)
            {
                Console.Write("Enter first number ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;

                Console.Write("Result is {0}", result);
            }

            else if (input == 4)
            {

                Console.Write("Enter first number ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 * num2;

                Console.Write("Result is {0}", result);

            }

            else
            {
                Console.Write("\nInvalid number");
            }

            
            

            Console.ReadLine();
        }
    }
}
