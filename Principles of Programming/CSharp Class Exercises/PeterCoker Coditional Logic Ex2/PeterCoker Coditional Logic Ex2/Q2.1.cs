using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPeterCoker_Coditional_Logic_Ex2
{
    class Q2
    {
        static void Main(string[] args)
        {
            //declare

            decimal fPrice, sPrice;
            double fWeight, sWeight, fWeightPerEuro, sWeightPerEuro;
            


            //Prompt

            Console.Write("Please enter weight and price of each package to compare\n\n");

            Console.Write("Enter weight of First Package in kilograms: ");
            fWeight = double.Parse(Console.ReadLine());

            Console.Write("Enter price of First Package price in euros: ");
            fPrice = decimal.Parse(Console.ReadLine());



            Console.Write("\nEnter weight of Second Package in kilograms: ");
            sWeight = double.Parse(Console.ReadLine());

            Console.Write("Enter price of Second Package in euros: ");
            sPrice = decimal.Parse(Console.ReadLine());


            fWeightPerEuro = fWeight / (double)fPrice;
            sWeightPerEuro = sWeight / (double)sPrice;

            Console.Clear();

            if (fWeightPerEuro > sWeightPerEuro)

            {
                Console.WriteLine("First package is the better price");
            }


            else if (sWeightPerEuro > fWeightPerEuro)
            {
                Console.WriteLine("Second package is the better price");
            }

            else 
                {
                    Console.WriteLine("They are both the same price");
                }

              
            

            






            Console.ReadLine();
        }
    }
}
