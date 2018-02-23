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
            Handle Handle = new Handle();
            RNG RNG = new RNG();
            int menuSelection = 0;
               
            //Loop menu selection until they input a valid option
            int looper = 1;
            while (looper == 1)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("Main Menu: \n");
                Console.WriteLine(" 1. Dice Roller \n 2. RNG \n 3. Battle Simulator \n 4. Handle Generator \n");
                int menuSelection1 = Int32.Parse(Console.ReadLine());
                
                //If menuSelection == one of the menu options, close the menu loop.
                if (menuSelection1 == 1 || menuSelection1 == 2 || menuSelection1 == 3 || menuSelection1 == 4)
                    {
                    menuSelection = menuSelection1;
                    looper++;
                    }
                    else
                    {
                    Console.WriteLine("That is not a valid option");
                    Console.WriteLine("Would you like to exit? y/n");
                    string exit = Console.ReadLine();
                    if (exit == "y")
                        Environment.Exit(0);
                    else
                        continue;
                                         
                    }
            }
           
            //Switch that runs the "sub" application. Runs a continue from that object class
            //at the end to continue using that sub app. 
            //IF MENU WAS AN OBJECT IT WOULD RETURN TO MENU.
            //TODO: Make Menu an object
            
            switch (menuSelection)
            {
                case 1:
                    Dice D = new Dice();
                    Console.WriteLine("Let's roll some dice! \n");
                    D.DiceToRoll();
                    D.RollDice(D.diceProperties[1], D.diceProperties[0]);
                    D.Continue();
                    break;
                case 2:
                    Console.WriteLine("Let's generate some rando's! \n");
                    RNG.HowMany();
                    RNG.Continue();
                    break;
                case 3:
                    Console.WriteLine("Ready for battle, are we?");
                    break;
                case 4:
                    Console.WriteLine("Let's get you a new handle.");
                    Handle.TrimString(Handle.HandleOptions());

                //  Handle.PrintTrim(); TEST METHOD FOR TRIMING THE ARRAY ENTRIES
                    
                    break;
            }

            Console.ReadKey();
        }

        
    }
}

