using DiceGame;
using System;

internal class Program
{
    // Author: Reed Stewart, Section: 001 Group 8, Description: Dice throwing simulator for IS 413 Class.
    private static void Main(string[] args)
    {
        // Create new instance of the roll class
        Roll r = new Roll(0);

        // Had some fun with the intro description and question (can you tell what the picture is? If so message me on slack @Reed Stewart and I will buy you a candy bar)
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine(" (0_0)                  ");
        System.Console.WriteLine(" \\ | __         ___    ");
        System.Console.WriteLine("  \\|/   '      (._.)        ");
        System.Console.WriteLine("   |      '     <|>         ");
        System.Console.WriteLine("  / \\    o o    _/\\_         ");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        // Gather the number of rolls that the user wants to play
        int rolls = int.Parse(System.Console.ReadLine());
        // Actually call the method to play the roll dice game
        int[] DiceTotal = r.RollLoop(rolls);

        // Print the introduction to the results
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of dice rolls");
        System.Console.WriteLine($"Total number of rolls = {rolls}");
        System.Console.WriteLine(" ");


        // Print the results in a histogram
        int index = 2;
        while (index <= 12)
        {
            // Find the percentage of the combination occurrence. Convert to double and find the number of asterix needed
            double percentage = (DiceTotal[index - 2] / (double)rolls) * 100;
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