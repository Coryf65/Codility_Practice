namespace Codility.Tests;

public class SmallestPositiveIntsTests
{
    [Theory]
    [InlineData(4, new int[] { 1, 2, 5, 9, 3, 6 })]
    [InlineData(5, new int[] { 1, 3, 6, 4, 1, 2 })]
    [InlineData(4, new int[] { 1, 2, 3 })]
    [InlineData(1, new int[] { -1, -3 })]
    [InlineData(1, new int[] { -1, -3, 0 })]
    public void Problem01_ExpectedResults_SmalledNumber_WithArrayInput_ExpectedSmallestPositiveNotInArray(int answer, int[] test)
    {
        int result = SmallestPositiveInt.solution(test);

        // Assert
        Assert.Equal<int>(answer, result);
    }
}