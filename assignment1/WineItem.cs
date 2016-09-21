using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        public int wineID;
        public string wineName;
        public string packString;

        public int WineID
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

        public string WineName
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

        public string PackString
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
            return ;
        }

        public WineItem(int id, string discription, string pack)
        {
            wineID = id;
            wineName = discription;
            packString = pack;
        }

        public WineItem()
        {
            
        }
    }
}
