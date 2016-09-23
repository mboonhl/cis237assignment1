using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class CSVProcessor
    {
        
        public static bool  ImortCsv(string pathToCsvFile, WineItem[] WineArray)
        {
            //Declare variable for stream Reader. Not going to instantiate yet
            StreamReader streamReader = null;

            //Try so anything that goes wrong can be caught
            try
            {
                //Declare a sting for each line we read in
                string line;

                //Instantiate the stream reader
                streamReader = new StreamReader(pathToCsvFile);

                
                int counter = 0;

                //while there is a line to read, processes it and input it to the 
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Calls the processLine method and send over the read in line
                    //the  employee array is passed by reference
                    //counter counts
                    ProcessLine(line, WineArray, counter++);
                    WineItemCollection wineItem = new WineItemCollection(counter);
                }
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                //Shows all method calls that lead to where the exception occurred
                Console.WriteLine(e.StackTrace);

                return false;
            }
            //Runs if passes or fails
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private static void ProcessLine(string line, WineItem[] WineArray, int index)
        {
            //splits items by commas
            string[] parts = line.Split(',');

        
            //Assign parts of array to variables
            string idNumber = parts[0];
            string discription = parts[1];
            string pack = parts[2];

            
            //Use the variables to instantiate a new Employee and assign it to the spot in the employees array by 
            //the index that was passed in
           WineArray[index] = new WineItem(idNumber, discription, pack);


        }

        }
    }

