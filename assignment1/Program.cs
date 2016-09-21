using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            WineItem thisWineItem = new WineItem();
            WineItemCollection thisWineItemCollection = new WineItemCollection();
            CSVProcessor thisCsvProcessor = new CSVProcessor();
            CSVProcessor[] wineListArray = new CSVProcessor[7500];


            int input = UserInterface.GetUserInputCsv();
            int choice = UserInterface.GetUserInput();

            while (input != 2)
            {
                //If one is chosen then it will go to the for each loop
                if (input == 1)
                {
                   
                    CSVProcessor.ImortCsv("./././datafiles/WineList.csv", wineListArray);

                }
            }

            //While the input is not 2 it continues in the loop to see what they want to do
            while (choice != 3)
            {
                //If one is chosen then it will go to the for each loop
                if (choice == 1)
                {
                    //String a made to concatenate the list in
                    string allOutput = "";

                    //loops through the employees to concatenate them.
                    foreach (CSVProcessor wine in wineListArray)
                    {
                        if (wine != null)
                        {
                            allOutput += wine.ToString() + Environment.NewLine;
                        }
                    }
                    //Once the loop is done the UI class will print the results
                    ui.PrintAllOutput(allOutput);
                }
                //Gets the next choice from the user
                choice = ui.getUserInput();
            }
        }
    }
}
