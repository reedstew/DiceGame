using DiceGame;

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
        r.RollLoop(rolls);
    }
}