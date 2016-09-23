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
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciates the WineItemCollection and CVSProcessor classes
            WineItemCollection thisWineItemCollection = new WineItemCollection();
            CSVProcessor thisCsvProcessor = new CSVProcessor();

            //Calls GetUserInputCSV method and passes the input to the ImportArray Method
            int input = UserInterface.GetUserInputCsv();
            thisWineItemCollection.ImportArray(input);

            //Calls GetUserInput method and passes the input to the LoopForArray Method
            int choice = UserInterface.GetUserInput();
            thisWineItemCollection.LoopForArray(choice);




        }
    }
}
 