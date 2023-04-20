namespace Codility;

public static class SmallestPositiveInt
{
    ///<Summary>
    /// Find the smallest possible int not listed in the array of ints
    /// <code>example: { 1, 3, 2, 9, 8, 6, 7, 5} = 4</code>
    ///</Summary>
    public static int solution(int[] A)
    {        
        // Implement your solution here
        int result = 1;

        // sort the array first
        Array.Sort(A);

       for (int i = 0; i < A.Length; i++)
        {
            int numberChecking = A[i];
            
            // removes negatives
            if (numberChecking < 0)
                continue;

            if (result < numberChecking)
                return result;

            result = numberChecking + 1;            
        }
        return result;
    }
}