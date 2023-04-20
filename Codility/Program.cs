using Codility;

Console.WriteLine("Test 01, SmallestPositiveInt");

// array of ints we will find the smallest not in here
int[] numbers =  { 1, 2, 5, 9, 3, 6 };
int answer = 4;
int result = SmallestPositiveInt.solution(numbers);

Utility.ConsoleCory(answer, result);

Console.WriteLine("Test 02, Binary Gap");

int number = 74;
answer = 2;
result = BinaryGap.Solution(number);

Utility.ConsoleCory(answer, result);

Console.WriteLine("Test 03, Parking Cost");

// "9:42", "11:42", 9
// "10:00", "13:21", 17
// "10:00", "10:30", 5
string startTime = "9:42";
string endTime = "11:42";
answer = 9;
result = ParkingCost.Solution(startTime, endTime);

Utility.ConsoleCory(answer, result);
