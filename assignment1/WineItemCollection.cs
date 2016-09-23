//Morgan Boon
//CIS237
//9/22/2016


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

        //Recieves user input and sends over the array and file location
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

        //Loop for choices to add item to the array or print the array
        public void LoopForArray(int choice)
        {
            
            
            while (choice != 3)
            {
                //If one is chosen then it will go to the foreach loop
                if (choice == 1)
                {
                    
                    string allOutput = "";

                    //loops through the WineArray to concatenate them.
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

                //If two is chosen then it calls the add item method
                if (choice == 2)
                {
                    AddItem();
                }
                //Gets the next choice from the user
                choice = UserInterface.GetUserInput();
            }
            
        }

      
        //Takes user input and adds item to the array
        public void AddItem()
        {
            ArrayCount();
            arrayIndex++;
            Console.WriteLine("Input ID");
            wineid = Console.ReadLine();
            Console.WriteLine("Input description");
            disc = Console.ReadLine();
            Console.WriteLine("Input pack");
            pack = Console.ReadLine();
            

            WineArray[arrayIndex] = new WineItem(wineid, disc, pack);
        }

        //Used to count the current number of items in the array
        private void ArrayCount()
        {
            foreach (WineItem numb in WineArray)
            {
                if (numb != null)
                {
                    arrayIndex++;
                }
            }
        }

      
    }
}
