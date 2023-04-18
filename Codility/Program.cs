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

result = BinaryGap.Solution(N);

Utility.ConsoleCory(answer, result);

// "9:42", "11:42", 9
// "10:00", "13:21", 17
// "10:00", "10:30", 5
string startTime = "9:42";
string endTime = "11:42";
answer = 9;

result = ParkingCost.Solution(startTime, endTime);

Utility.ConsoleCory(answer, result);
