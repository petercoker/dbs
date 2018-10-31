using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCoker_Coditional_Logic_Ex1
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            string myInput;
                int myInt;

                begin:

                Console.Write("Please enter a number 1 and 3: ");
                myInput = Console.ReadLine();
                myInt = Int32.Parse(myInput);

                switch (myInt)
                {
                    case 1:
                        Console.WriteLine("Your number is {0}.", myInt);
                        break;

                    case 2:
                        Console.WriteLine("Your number is {0}.", myInt);
                        break;

                    case 3:
                        Console.WriteLine("Your number is {0}.", myInt);
                        break;

                    default:

                        Console.WriteLine("Your number {0} is not between 1 and 3.", myInt);
                        break;

                }

                decide:

                Console.Write("Type \"continue\" to go on or \"quit\" to stop: ");
                myInput = Console.ReadLine();

                switch (myInput)
                {
                    case "continue":
                        goto begin;

                    case "quit":
                        Console.WriteLine("Fuck off");
                        break;

                    default:
                        Console.WriteLine("Your input {0} is incorrecct. ", myInput);
                        goto decide;

                }

                Console.ReadLine();
                

            
        }
    }
}
