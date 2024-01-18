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
        private int[] DiceTotal = new int[11];

        // Constructor
        public Roll(int num)
        {
            // nothing here
        }

        public void RollLoop(int num)
        {
            // DiceTotal.Clear();
            // instance of random
            Random random = new Random();

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

            // Print the introduction to the results
            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each \"*\" represents 1% of the total number of dice rolls");
            System.Console.WriteLine($"Total number of rolls = {num}");
            System.Console.WriteLine(" ");


            // Print the results in a histogram
            int index = 2;
            while (index <= 12)
            {
                // Find the percentage of the combination occurrence. Convert to double and find the number of asterix needed
                double percentage = (DiceTotal[index - 2] / (double)num) * 100;
                int numast = (int)Math.Round(percentage);
                // line up the 2-9 combinations with 10-12 on the printout (for the OCD people)
                string space = index >= 2 && index <= 9 ? " " : "";
                // Actually make the histogram
                System.Console.WriteLine($"{space}{index}: {new string('*', numast)}");
                index++;
            }
            // Give the thahk you message
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
