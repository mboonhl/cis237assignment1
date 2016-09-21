using System;

namespace assignment1
{
    internal static class UserInterface
    {
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

        public static int GetUserInput()
        {
            //Call printMenu method and quantify it using the name of the class and not this. 
            //It does the same thing as this but this refers to and instance and static classes cannot have instances 
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
            //when the input is valid we can then parse the input
            return int.Parse(input);
        }

        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private static void PrintCsvMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load Wine list");
            Console.WriteLine("2. Exit Program");
        }

        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Add item to wine list");
            Console.WriteLine("3. Exit");
        }
       
    }
}