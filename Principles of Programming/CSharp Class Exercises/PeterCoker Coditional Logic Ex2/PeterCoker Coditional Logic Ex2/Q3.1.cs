using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex2
{
    class Q3
    {
        static void Main(string[] args)
        {
            //Declare 
            double  a, b, c, perimeter;


            //Prompt
            Console.Write("Please enter the length of edge of a, b and c to calculate the Perimeter the Triangle\n\n");

            Console.Write("\nEnter length of edge a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\nEnter length of edge b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("\nEnter length of edge c: ");
            c = double.Parse(Console.ReadLine());

            Console.Clear();

            
            if (a + b > c && b + c > a && a + c > b)
            {

                perimeter = a + b + c; 

                Console.Write("\nPerimeter is {0:0.00}", perimeter);
            }

            else
            {
                Console.Write("input is invalid");
            }

            

                




            Console.ReadLine();
        }
    }
}
