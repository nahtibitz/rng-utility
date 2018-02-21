using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Dice
    {
        public Dice()
        {

        }
        //Number of sides in [0] and number of dice in [1]
        public int[] diceProperties = new int[2];
        public int[] DiceToRoll()
        {
            Console.WriteLine("How many sides does your die have?");
            int numberOfSides = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many dice would you like to roll?");
            int numberOfDice = Int32.Parse(Console.ReadLine());
            diceProperties[0] = numberOfSides;
            diceProperties[1] = numberOfDice;

            return diceProperties;
        }

        public void RollDice(int dice, int numberofSides)
        {
            Random rando = new Random();
            for (int x = 0; x < dice; x++)
            {
                Console.WriteLine("Your " + x + " roll of a " + numberofSides + " die is: " + rando.Next(numberofSides));
                Console.WriteLine("++--+--++--+--++--+--++--+--++--+--++--+--++");
            }
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
                    DiceToRoll();
                    RollDice(diceProperties[1],diceProperties[0]);
                }
            }
        }
    }
}
