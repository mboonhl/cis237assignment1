//Morgan Boon
//CIS237
//9/22/2016

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
        
        //Reads the CSV file sends each line to the ProcessLine method while the line contains data
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
                    
                    ProcessLine(line, WineArray, counter++);
                    
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
            
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        //Splits each line by commas then creates a new instance of the array at the index 
        private static void ProcessLine(string line, WineItem[] WineArray, int index)
        {
            
            string[] parts = line.Split(',');

        
           
            string idNumber = parts[0];
            string discription = parts[1];
            string pack = parts[2];

            
            
           WineArray[index] = new WineItem(idNumber, discription, pack);


        }


        }
    }

