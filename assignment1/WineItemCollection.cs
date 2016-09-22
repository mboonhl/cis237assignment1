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
        WineItemCollection[] WineArray = new WineItemCollection[7500];


        public void ImportArray(int input)
        { 
            

            while (input != 2)
            {
                //If one is chosen then it will go to the for each loop
                if (input == 1)
                {

                     CSVProcessor.ImortCsv("WineList.csv", WineArray); 

                }
            }
            
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
                    foreach (WineItemCollection wine in WineArray)
                    {
                        if (wine != null)
                        {
                            allOutput += wine.ToString() + Environment.NewLine;
                        }
                    }
                    //Once the loop is done the UI class will print the results
                    UserInterface.PrintAllOutput(allOutput);
                }
                //Gets the next choice from the user
                choice = UserInterface.GetUserInput();
            }
            
        }

        
        public void addItem(string ID, string Name, string Pack)
        {
            
        }

        public WineItemCollection(string _wineID, string _wineName, string _packString)
        {
            wineid = _wineID;
            disc = _wineName;
            pack = _packString;
        }

        public WineItemCollection()
        {
            
        }
    }
}
