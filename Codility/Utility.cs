namespace Codility;

public static class Utility
{
    public static void ConsoleCory(int answer, int result)
    {
        if (answer == result)
            Console.BackgroundColor = ConsoleColor.Green;
        else
            Console.BackgroundColor = ConsoleColor.Red;

        Console.WriteLine("Answer: {0}", answer);
        Console.WriteLine("Got:    {0}", result);
        Console.BackgroundColor = ConsoleColor.Black;
    }
}