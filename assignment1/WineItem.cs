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
    class WineItem
    {
        //Variables for WineID, WineName and packString
        public string wineID;
        public string wineName;
        public string packString;
        
        //Sends current variable values when method is called
        public override string ToString()
        {
            return wineID + " " + wineName + " " + packString;
        }

        //Constructor sets values to variables
        public WineItem(string _wineID, string _wineName, string _packString)
        {
            wineID = _wineID;
            wineName = _wineName;
            packString = _packString;
        }

        //Defalt consturctor is needed because we made a new construtor
        public WineItem()
        {
            
        }
    }
}
 