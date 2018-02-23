using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Handle
    {
        //Instance variables
        string[] inputNames = new string[10];
        string[] arrayOf3 = new string[20]; //Stores the names after they are trimmed and stripped

        //Constructor
        public Handle()
        {

        }

        //Print the main line for the menu generator, and 
        //create an array based off the names provided.
        //This should be two methods, tbh

        public string[] HandleOptions()
        {
            Console.WriteLine("Input up to 10 names that you would like to generate a name from.");

            int looper = 0;
            do
            {
                for (int x = 0; x < inputNames.Length; x++)
                {
                    inputNames[x] = Console.ReadLine();
                    if (String.IsNullOrEmpty(inputNames[x]))
                    {
                        looper++;

                        x = inputNames.Length;
                    }
                }
            }
            while (looper == 0);
            return inputNames;

        }

        /// <summary>
        /// Trim the whitespace down and split the strings into groups of 3 characters per name
        /// </summary>
        public void TrimString(string[] ArrayToTrim)
        {
            //Trim any whitespace
            for (int x = 0; x < ArrayToTrim.Length; x++)
            {
                if (inputNames[x] == null)
                {
                    continue;
                }
                else
                {
                    inputNames[x] = ArrayToTrim[x].Trim();
                }
            }
        }


        public void SplitString(string[] ArrayToSplit)
        {
            int looper = 0;
            while (looper == 0)
            {
                for (int x = 0; x < inputNames.Length; x++)
                {

                }
            }


        }
        /*TEST METHOD FOR TRIM
          public void PrintTrim()
        {
            for(int x = 0; x < inputNames.Length;x++)
                Console.WriteLine(inputNames[x]);
        } */


        public string[] PrintNames()
        {
            string[] names = new string[10];  //wtf

            return names;
        }

        public void Continue()
        {
            Console.WriteLine("Would you like to continue generating handles?");

            Console.ReadKey();
        }
    }
}
