namespace Codility.Tests;

public class Solution01Tests
{
    [Theory]
    [InlineData(true, 4, new { 1, 2, 5, 9, 3, 6 })]
    [InlineData(true, 5, new { 1, 3, 6, 4, 1, 2 })]
    [InlineData(true, 4, new { 1, 2, 3 })]
    [InlineData(true, 1, new { -1, -3 })]
    [InlineData(true, 1, new { -1, -3, 0 })]
    public void Problem01_ExpectedResults_SmalledNumber_WithArrayInput_ExpectedSmallestPositiveNotInArray(bool expected, int answer, int[] test)
    {
        // Arrange
        int result = 1;

        // Act
        
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

        // Assert
        Assert.Equal(answer, result);
    }

    [Theory]
    [InlineData(true, "expected", new string[] { "expected", "another" })]
    [InlineData(false, "nope!", new string[] { "expected", "another" })]
    public async void StringCheck_WithInputs_ExpectResultsMatch(bool expectedResult, string expectedString, string[] possibleStrings)
    {
        bool actualResult = false;

        foreach(var row in possibleStrings)
        {
            if(row == expectedString)
            {
                actualResult = true;
            }
        }

        Assert.Equal(expectedResult, actualResult);
    }
}