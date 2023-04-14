namespace Codility.Tests;

public class UnitTest1
{
    // cool example for xunit tests
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