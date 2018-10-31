using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerWeek1Exercise2
{
    class Q7
    {
        static void Main(string[] args)
        {   
            // declare
        
            string name;
            int age;
            double grossPay, taxRate, netPay;

            //Prompt

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your gross pay: ");
            grossPay = double.Parse(Console.ReadLine());

            Console.Write("Enter your tax rate: ");
            taxRate = double.Parse(Console.ReadLine());

            taxRate = taxRate / 100;


            //sum

            netPay = grossPay - grossPay * taxRate;

            Console.WriteLine("Name: {0}\nAge: {1}\nGross Pay: {2}\nTax Rate: {3}\nNet Pay: {4}", name, age, grossPay, taxRate, netPay);


            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
