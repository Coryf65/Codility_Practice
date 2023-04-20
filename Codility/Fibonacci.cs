namespace Codility;

public static class Fibonacci
{
    ///<Summary>
    /// Calculating the Fibonacci sequence the easiest way by using a for loop
    ///</Summary>
    public static void SolutionForLoop(int length)
    {
        int a =0;
        int b = 1;
        int c = 0;

        Console.Write($"{a} {b}");

        for (int i = 2; i < length; i++)
        {
            c = a + b;

            Console.Write($" {c}");
            a = b;
            b = c;
        }
        Console.WriteLine();
    }

    public static void SolutionRecursive(int length)
    {
        FibRecursion(0, 1, 1, length);
    }

    private static void FibRecursion(int a, int b, int counter, int length)
    {
        if (counter <= length)
        {
            Console.Write($"{a} ");
            FibRecursion(b, a + b, counter += 1, length);            
        }
    }
}