namespace Codility.Tests;

public class BinaryGapTests
{

	[Theory]
	[InlineData(0, 32)] // 100000
	[InlineData(5, 1041)] // 10000010001
	[InlineData(2, 800)] // 1100100000
	[InlineData(2, 74)] // 1001010
	public void BinaryGap_TotalZerosWithOnesSurrounding_MyAnswer(int answer, int test)
	{
		// Arrange, Act
		int result = BinaryGap.Solution(test);

		// Assert
		Assert.Equal<int>(answer, result);
	}

	[Theory]
	[InlineData(0, 32)] // 100000
	[InlineData(5, 1041)] // 10000010001
	[InlineData(2, 800)] // 1100100000
	[InlineData(2, 74)] // 1001010
	public void BinaryGap_TotalZerosWithOnesSurrounding_FoundAnswer(int answer, int test)
	{
		// Arrange, Act
		int result = BinaryGap.FoundSolution(test);

		// Assert
		Assert.Equal<int>(answer, result);
	}
}