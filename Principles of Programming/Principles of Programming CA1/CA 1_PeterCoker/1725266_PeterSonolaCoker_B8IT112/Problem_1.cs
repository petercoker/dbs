using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1725266_PeterSonolaCoker_B8IT112
{
    class Problem_1
    {
        static void Main(string[] args)
        {
            //Declaration of variables.
            string dataRow;
            char delimiter;

            //Try Catch method was used to prompt the user to enter one delimiter.
            try
            {
                //Prompt the user to enter a delimited data row.
                Console.WriteLine("Please enter a data row");
                dataRow = Console.ReadLine();

                //Prompt the user to enter delimiter.
                Console.WriteLine("Please enter the delimiter");
                delimiter = Char.Parse(Console.ReadLine());

                //Split method is used to tokenize the strings.
                String[] split = dataRow.Split(delimiter);

                //The foreach loop is used to iterate through the items of each string.
                foreach (string userDelimiter in split)
                {
                    Console.WriteLine(userDelimiter);
                }
            }

            //Display from error message "Error, please enter one delimiter."
            //System.Exception errors message was changed to prompt the user “Error, please enter one delimiter”.
            catch (System.Exception)
            {
                Console.WriteLine("\a\nError, please enter one delimiter.");
            }

            //Output "Press any key to continue".
            Console.Write("Press any key to continue . . .");

            Console.ReadLine();
        }
    }
}
