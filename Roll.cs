using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Roll
    {
        // Constructor
        public Roll(int num)
        {
            int nRolls = num;
        }

        public void RollLoop(int num)
        {
            // instance of random
            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                // Generate a random number between 1 and 6
                int randnum = random.Next(1, 7);
                // Give the result
                System.Console.WriteLine("Roll " + (i + 1) + ": " + randnum);
            };
        }
    }
}
