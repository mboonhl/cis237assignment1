using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        public string wineid;
        public string disc;
        public string pack;
        public int arrayIndex;
        WineItem[] WineArray = new WineItem[7500];


        public bool ImportArray(int input)
        { 
            

            while (input != 2)
            {
                //If one is chosen then it will go to the for each loop
                if (input == 1)
                {

                     CSVProcessor.ImortCsv("../../../datafiles/WineList.csv", WineArray);
                    return true;
                }
            }
            return true;
        }

        public void LoopForArray(int choice)
        {
            
            //While the input is not 2 it continues in the loop to see what they want to do
            while (choice != 3)
            {
                //If one is chosen then it will go to the for each loop
                if (choice == 1)
                {
                    //String a made to concatenate the list in
                    string allOutput = "";

                    //loops through the employees to concatenate them.
                    foreach (WineItem wine in WineArray)
                    {
                        if (wine != null)
                        {
                            allOutput += wine.ToString() + Environment.NewLine;
                        }
                    }
                    //Once the loop is done the UI class will print the results
                    UserInterface.PrintAllOutput(allOutput);
                }
                if (choice == 2)
                {
                    addItem();
                }
                //Gets the next choice from the user
                choice = UserInterface.GetUserInput();
            }
            
        }

        public WineItemCollection(int index)
        {
            arrayIndex = index + 1;
        }

        public WineItemCollection()
        {
            
        }

        public void addItem()
        {
            Console.WriteLine(arrayIndex);
            Console.WriteLine("Input ID");
            wineid = Console.ReadLine();
            Console.WriteLine("Input description");
            disc = Console.ReadLine();
            Console.WriteLine("Input pack");
            pack = Console.ReadLine();
            

            WineArray[arrayIndex] = new WineItem(wineid, disc, pack);
        }

      
    }
}
