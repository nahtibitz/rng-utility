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
            /* Create main menu using switch statement to select option
             * Allow option for rolling dice?
             * Allow option for random name generator based on input?
             * ROLL FOR CRITS?!
             */
            RNG RNG = new RNG();
            int menuSelection = 0;
                                
            int looper = 1;
            while (looper == 1)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("Main Menu: \n");
                Console.WriteLine(" 1. Dice Roller \n 2. RNG \n 3. Battle Simulator \n 4. Handle Generator \n");
                int menuSelection1 = Int32.Parse(Console.ReadLine());
                
                if (menuSelection1 == 1 || menuSelection1 == 2 || menuSelection1 == 3 || menuSelection1 == 4)
                    {
                    menuSelection = menuSelection1;
                    looper++;
                    }
                    else
                    {
                    Console.WriteLine("That is not a valid option");
                    }
            }
           
            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine("Let's roll some dice!");
                    break;
                case 2:
                    Console.WriteLine("Let's generate some rando's!");
                    RNG.HowMany();
                    RNG.Continue();

                    break;
                case 3:
                    Console.WriteLine("Ready for battle, are we?");
                    break;
                case 4:
                    Console.WriteLine("Let's get you a new handle.");
                    break;
            }

            Console.ReadKey();
        }

        
    }
}

