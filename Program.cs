//Programmer: Shane Scallon
//Date: 1/29/2020
//Description: This C# console application demonstrates iterative statments
//after getting input from users

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user for an input of an interger
            Console.WriteLine("Enter an interger between 1 and 100");

            //Try-catch to validate user input
            //when bad input is used a message will show stating an interger should be entered
            try
            {
                //Variable gathers input from users
                string input = Console.ReadLine();



            }
            catch
            {
                Console.WriteLine("Please run the program again and enter an interger value");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }

        }
    }
}
