// See https://aka.ms/new-console-template for more information
Console.WriteLine("Test 01");

// should return 5
int[] A = { 1, 3, 6, 4, 1, 2 };

int test = Solution_01.solution(A);

Console.WriteLine("Answer: 5");
Console.WriteLine("Got:    {0}", test);


public static class Solution_01 {
    public static int solution(int[] A) {        
        // Implement your solution here

        int result = 1;

        // sort the array first
        Array.Sort(A);

       for (int i = 1; i < A.Length; i++)
        {
            int numberChecking = A[i];
            result = i;       
            Console.WriteLine("i: '{0}'", i);
            Console.WriteLine("A[i]: '{0}'", A[i]);

            // must be > 0
            if (numberChecking <= 0)
                continue;
            
            // must not be in the A array
            if(result == numberChecking)
                continue;

        }
        return result;
    }
}