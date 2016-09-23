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
            WineItemCollection thisWineItemCollection = new WineItemCollection();
            CSVProcessor thisCsvProcessor = new CSVProcessor();


            int input = UserInterface.GetUserInputCsv();
            thisWineItemCollection.ImportArray(input);

            int choice = UserInterface.GetUserInput();
            thisWineItemCollection.LoopForArray(choice);




        }
    }
}
 