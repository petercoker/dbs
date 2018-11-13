using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1725266_PeterSonolaCoker_B8IT112
{
    class Problem_3
    {
        static void Main(string[] args)
        {
            //Prompt user "WELCOME TO THE DBS CONSOLE"
            Console.WriteLine("###################################");
            Console.WriteLine("WELCOME TO THE DBS CONSOLE");
            Console.WriteLine("###################################");

            //Declaration of single dimension arrays.
            string[] userMovieName = new string[5];

            //Declaration of variable.
            int movieNumber;
            string exit = "exit";

            //User input elements of array movieName depending on the amount stored array.
            for (int enterMovieName = 0; enterMovieName < 5; enterMovieName++)
            {
                Console.WriteLine("Enter Movie Name:");
                userMovieName[enterMovieName] = Console.ReadLine();

                //For loop end if user enters "exit" into the stored array. 
                if (userMovieName[enterMovieName] == exit)
                {
                    break;
                }
            }

            //Create a space between input and output of prompting the User to enterMovieName.
            Console.Write("\n");

            //A for loop was used to output the movie number and movie name.
            for (movieNumber = 0; movieNumber < 5; movieNumber++)
            {
                //Not to include Movie name after when entering the word exit.
                if (userMovieName[movieNumber] == exit)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Movie {0} is {1}", movieNumber + 1, userMovieName[movieNumber]);
                }
            }

            //Prompt user "Press any key to continue"
            Console.Write("Press any key to continue . . .");

            Console.ReadLine();
        }
    }
}

