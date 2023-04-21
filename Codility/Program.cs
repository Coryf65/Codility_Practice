using Codility;

Utility.Title("Test 01, SmallestPositiveInt");

// array of ints we will find the smallest not in here
int[] numbers =  { 1, 2, 5, 9, 3, 6 };
int answer = 4;
int result = SmallestPositiveInt.solution(numbers);

Utility.ColorConsole(answer, result);

Utility.Title("Test 02, Binary Gap");

int number = 74;
answer = 2;
result = BinaryGap.Solution(number);

Utility.ColorConsole(answer, result);

Utility.Title("Test 03, Parking Cost");

// "9:42", "11:42", 9
// "10:00", "13:21", 17
// "10:00", "10:30", 5
string startTime = "9:42";
string endTime = "11:42";
answer = 9;
result = ParkingCost.Solution(startTime, endTime);

Utility.ColorConsole(answer, result);

Utility.Title("Test 04, Calculate Fibonacci to x");

int totalLength = 10;

Console.WriteLine("Fibonacci using a for loop");
Fibonacci.SolutionForLoop(totalLength);

Console.WriteLine("\nFibonacci using a recursive function");
Fibonacci.SolutionRecursive(totalLength);

Console.WriteLine("\n");

Utility.Title("Lowest Unique int");

// Example test:   [1, 4, 3, 3, 1, 2]
// Output:
// 1
// WRONG ANSWER (got 1 expected 4)
//[4, 10, 5, 4, 2, 10] = 5

// int[] A = { 1, 4, 3, 3, 1, 2 };
// answer = 4;

// int[] A = { 4, 5, 4, 2, 10 };
// answer = 5;

int[] A = { 6, 4, 4, 6 };
answer = -1;

result = UniqueInt.Solution(A);

Utility.ColorConsole(answer, result);

// QUIZ space below, start soon
Utility.Title("Codility Test");

// setup
string[] args1 = {"--name", "SOME_NAME", "--count", "10" };
string[] args2 = {"--NAME", "SOME_NAME", "--COUNT", "10" };

// expected answer
answer = 0;


ValidateArguments validator = new();

result = validator.Validate(args1);

Utility.ColorConsole(answer, result);

result = validator.Validate(args2);

Utility.ColorConsole(answer, result);