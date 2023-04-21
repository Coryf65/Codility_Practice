namespace Codility.Tests;

public class UniqueIntTests
{
	[Theory]
	[InlineData(5, new int[] { 4, 10, 5, 4, 2, 10 })]
	[InlineData(4, new int[] { 1, 4, 3, 3, 1, 2 })]
	[InlineData(-1, new int[] { 6, 4, 4, 6 })]
	[InlineData(0, new int[] { 0 })]
	[InlineData(-1, new int[] {})]
	public void UniqueInt_FindingFirstUnique(int answer, int[] test)
	{
		// Arrange, Act
		int result = UniqueInt.Solution(test);

		// Assert
		Assert.Equal<int>(answer, result);
	}
}