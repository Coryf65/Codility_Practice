using Codility;

namespace Codility.Tests;


public class Solution01Tests
{
    [Theory]
    [InlineData(true, 4, new int[] { 1, 2, 5, 9, 3, 6 })]
    [InlineData(true, 5, new int[] { 1, 3, 6, 4, 1, 2 })]
    [InlineData(true, 4, new int[] { 1, 2, 3 })]
    [InlineData(true, 1, new int[] { -1, -3 })]
    [InlineData(true, 1, new int[] { -1, -3, 0 })]
    public void Problem01_ExpectedResults_SmalledNumber_WithArrayInput_ExpectedSmallestPositiveNotInArray(bool expected, int answer, int[] test)
    {          
        int result = Solution_01.solution(test);               

        // Assert
        Assert.Equal<int>(answer, result);
    }

    [Theory]
    [InlineData(true, "expected", new string[] { "expected", "another" })]
    [InlineData(false, "nope!", new string[] { "expected", "another" })]
    public void StringCheck_WithInputs_ExpectResultsMatch(bool expectedResult, string expectedString, string[] possibleStrings)
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