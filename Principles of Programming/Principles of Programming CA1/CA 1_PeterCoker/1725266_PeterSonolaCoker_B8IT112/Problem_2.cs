using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1725266_PeterSonolaCoker_B8IT112
{
    class Problem_2
    {
        static void Main(string[] args)
        {
            //Prompt the user "WELCOME TO THE DBS CONSOLE".
            Console.WriteLine("###################################");
            Console.WriteLine("WELCOME TO THE DBS CONSOLE");
            Console.WriteLine("###################################");

            //Try Catch method was used to prompt the user to enter only numbers.
            try
            {
                //Declaration of variable.
                int inputNumber, i, j, count;

                //Prompt the user to enter 5 integer value.
                Console.Write("Input the number of elements to be stored in the array :");
                inputNumber = int.Parse(Console.ReadLine());

                //Used to ensure that the user enter a number above 0 or under 6.
                if (inputNumber >= 1 && inputNumber >= 6)
                {
                    Console.WriteLine("\nPlease enter a number of elements to be stored in the array that is above 0 or lower than six");
                    Console.ReadLine();
                }

                else
                {
                    Console.Write("Input {0} elements in the array :\n", inputNumber);

                    //Declaration of single dimension arrays.
                    int[] userValueNumber = new int[inputNumber];
                    int[] duplicate = new int[inputNumber];

                    //User input elements of array userValueNumber depending on the amount stored array.
                    for (i = 0; i < userValueNumber.Length; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        userValueNumber[i] = int.Parse(Console.ReadLine());
                        duplicate[i] = -1;
                    }

                    //Process used to count the number of duplicate of each elements of the userValueNumber array. 
                    for (i = 0; i < userValueNumber.Length; i++)
                    {
                        count = 1;
                        for (j = i + 1; j < userValueNumber.Length; j++)
                        {
                            if (userValueNumber[i] == userValueNumber[j])
                            {
                                count++;
                                duplicate[j] = 0;
                            }
                        }

                        //Not to count non-duplicate. 
                        if (duplicate[i] != 0)
                        {
                            duplicate[i] = count;
                        }
                    }

                    //Prompt the user "The frequency of all elements of the array" of userValueNumber array.
                    Console.Write("\nThe frequency of all elements of the array : \n");

                    //A For loop was used to output the frequency of all elements.
                    for (i = 0; i < userValueNumber.Length; i++)
                    {
                        //Not to output non-occurrence.
                        if (duplicate[i] != 0)
                        {
                            Console.WriteLine("{0} occurs {1} times", userValueNumber[i], duplicate[i]);
                        }
                    }
                }
            }

            catch
            {
                //Prompt User Error message if they do not input integer value.
                Console.WriteLine("\a\nError, please enter only numbers.");
            }

            Console.ReadLine();
        }
    }
}

