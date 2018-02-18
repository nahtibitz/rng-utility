using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--- We're entering a method ---+");

            HowMany();

            Continue();

            Console.ReadKey();
        }

         static int HowMany()
        {
            Random rando = new Random();
            Console.WriteLine("How many random numbers would you like to generate");
            int number1 = Int32.Parse(Console.ReadLine());

            for (int x = 1; x <= number1; x++)
                Console.WriteLine(rando.Next(100));

            return number1;
        }
        
        static void Continue()
        {
            
            int looper = 0;
            while (looper == 0)
            {
                Console.WriteLine("Would you like to generate more random numbers?");
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

