using Codility;

Console.WriteLine("Test 01, SmallestPositiveInt");

// should return 5
int[] A =  { 1, 2, 5, 9, 3, 6 };
int answer = 4;

int result = SmallestPositiveInt.solution(A);

Utility.ConsoleCory(answer, result);

Console.WriteLine("Test 02, Binary Gap");

int N = 20;
answer = 1;

result = BinaryGap.solution(N);

Utility.ConsoleCory(answer, result);