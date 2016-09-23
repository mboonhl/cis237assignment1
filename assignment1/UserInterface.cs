//Morgan Boon
//CIS237
//9/22/2016

using System;

namespace assignment1
{
    internal static class UserInterface
    {
        //Promts user to input choice and sends over int to CSV processor to do what is chosen
        public static int GetUserInputCsv()
        {
            PrintCsvMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();

                PrintCsvMenu();
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }

        //Gets user input and sends data to WineItemCollecton class to be processed
        public static int GetUserInput()
        {
             
            PrintMenu();

            //Get input form the console
            var input = Console.ReadLine();

            //Continues to loop while the input is not a valid choice
            while ((input != "1") && (input != "2") && (input != "3"))
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();

                PrintMenu();
                input = Console.ReadLine();
            }
            
            return int.Parse(input);
        }

        //Prints all output from the array
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        //Prints CSV menu
        private static void PrintCsvMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load Wine list");
            Console.WriteLine("2. Exit Program");
        }

        //Prints menu to add or print the array
        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Add item to wine list");
            Console.WriteLine("3. Exit");
        }
       
    }
}