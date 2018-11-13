using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Q4
    {
        static void Main(string[] args)
        {
            decimal salary;
            double taxRate, tax;
            taxRate = 0;

            Console.Write("Please enter your salaray ");
            salary = decimal.Parse(Console.ReadLine());

            if (salary <= 10000)
            {
                taxRate = 0;
                tax = (double)salary * taxRate; 
            }

            else if (salary <= 50000)
            {
                taxRate = 0.20;
                tax = ((double)salary - 10000) * taxRate;
            }

            else
            {
                taxRate = 0.40;
                tax = 40000 * 0.20 + ((double)salary - 50000) * taxRate;

            }

            Console.WriteLine("Your tax is {0}", tax);
            Console.ReadLine();
        }
    }
}
