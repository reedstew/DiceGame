using DiceGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Roll r = new Roll(0);

        int rolls = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine(" (0_0)                  ");
        System.Console.WriteLine(" \\ | __         ___    ");
        System.Console.WriteLine("  \\|/   '      (._.)        ");
        System.Console.WriteLine("   |      '     <|>         ");
        System.Console.WriteLine("  / \\    o o    _/\\_         ");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        rolls = int.Parse(System.Console.ReadLine());

        r.RollLoop(rolls);
    }
}