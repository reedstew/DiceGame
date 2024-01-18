using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Roll
    {
        List<int> DiceTotal = new List<int>();

        // Constructor
        public Roll(int num)
        {
            // nothing here
        }

        public void RollLoop(int num)
        {
            DiceTotal.Clear();
            // instance of random
            Random random = new Random();

            // Loop which rolls both of the dice
            for (int roll = 0; roll < num; roll++)
            {
                // generate numbers for the dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // for look places a 0 in each place in list
                if (sum >= 2 && sum <= 12)
                {
                    DiceTotal[sum - 2]++;
                }
            }   
            
                // Print the results of dice rolls
                System.Console.WriteLine("Results of dice rolls: " + string.Join(", ", DiceTotal));
        }
    }
}
