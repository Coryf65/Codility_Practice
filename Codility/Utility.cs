namespace Codility;

public static class Utility
{
    ///<summary>
    /// Colors the console according the to result and the answer matching, Green for matches and red for not matching
    ///</summary>
    public static void ColorConsole(int answer, int result)
    {
        if (answer == result)
            Console.BackgroundColor = ConsoleColor.Green;
        else
            Console.BackgroundColor = ConsoleColor.Red;

        Console.Write("Answer: {0}\n", answer);
        Console.Write("Got:    {0}\n", result);

        Console.ResetColor();
        Console.WriteLine();        
    }

    public static void Title(string title)
    {
        Console.WriteLine(title);

        foreach (char item in title)
        {
            Console.Write("-");
        }
        
        Console.WriteLine("\n");
    }
}