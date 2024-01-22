using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    // Author: Reed Stewart, Section: 001 Group 8, Description: Dice throwing simulator for IS 413 Class.
    internal class Roll
    {
        
        public Roll(int num)
        {
            // nothing here
        }

        public int[] RollLoop(int num)
        {
            // DiceTotal.Clear();
            // instance of random
            Random random = new Random();

            int[] DiceTotal = new int[11];

            // Loop which rolls both of the dice
            for (int roll = 0; roll < num; roll++)
            {
                // generate numbers for the dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // System.Console.WriteLine(DiceTotal.Count);
                // Update the counter for the current sum
                if (sum >= 2 && sum <= 12)
                {
                    DiceTotal[sum - 2] = DiceTotal[sum - 2] + 1;
                }
            }

            return DiceTotal;
        }
    }
}
