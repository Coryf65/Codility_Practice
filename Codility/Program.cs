using Codility;

Console.WriteLine("Test 01, SmallestPositiveInt");

// should return 5
int[] A =  { 1, 2, 5, 9, 3, 6 };
int answer = 4;

int result = SmallestPositiveInt.solution(A);

if (answer == result)
    Console.BackgroundColor = ConsoleColor.Green;
else
    Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine("\n");
Console.WriteLine("Answer: {0}", answer);
Console.WriteLine("Got:    {0}", result);
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Test 02, ");

