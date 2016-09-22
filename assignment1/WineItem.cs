using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        public static string wineID;
        public static string wineName;
        public static string packString;

        public static string WineID
        {
            get
            {
                return wineID;
            }

            set
            {
                wineID = value;
            }
        }

        public static string WineName
        {
            get
            {
                return wineName;
            }

            set
            {
                wineName = value;
            }
        }

        public static string PackString
        {
            get
            {
                return packString;
            }

            set
            {
                packString = value;
            }
        }

        public override string ToString()
        {
            return wineID + " " + wineName + " " + packString;
        }

        public WineItem(string _wineID, string _wineName, string _packString)
        {
            wineID = _wineID;
            wineName = _wineName;
            packString = _packString;

        }

        public WineItem()
        {
            
        }
    }
}
 