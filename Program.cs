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

                //This variable will be used to perform iterative statements and is parsed as an interger
                int input_value = int.Parse(input);

                //If the value the user inputs is between 1 & 100 run a for loop
                if (input_value > 0 && input_value < 101)
                {

                    for (int i= 1; i <= input_value; i++)
                    {
                        //first displays the input the user entered.
                        //then displays the interger value in the loop
                        Console.WriteLine("You have entered " + input.ToString());
                        Console.WriteLine("The current interger value in this loop is " + i.ToString());

                    }
                    //Prompt the user to press a key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please restart the console and enter an interger between 1 and 100");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }//end of try
            catch
            {
                Console.WriteLine("Please run the program again and enter an interger value");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }//end of catch

        }
    }
}
