using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning

{
    class RNG
    {
        public int HowMany()
        {
            Random rando = new Random();
            Console.WriteLine("How many random numbers would you like to generate?");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is the maximum number you would like to generate to?"); //Needs better phrasing
            int maxNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Your {0} random numbers with a max of {1} are:", number1, maxNumber); //Formatting to seperate numbers for readability

            for (int x = 1; x <= number1; x++)
                Console.WriteLine(rando.Next(maxNumber));

            return number1;
        }

        public void Continue()
        {

            int looper = 0;
            while (looper == 0)
            {
                Console.WriteLine("Would you like to continue?");
                string yesNo = Console.ReadLine();
                if (yesNo == "n")
                    looper++;
                else
                {
                    HowMany();
                }
            }
        }
    }
}
