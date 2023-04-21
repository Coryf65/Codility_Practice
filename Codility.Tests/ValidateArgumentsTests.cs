namespace Codility.Tests;

public class VaildateArgumentsTests
{

	[Theory]
	[InlineData(0, new string[] { "--name", "SOME_NAME", "--count", "10" })]
	[InlineData(0, new string[] { "--NAME", "SOME_NAME", "--COUNT", "10" })]
	[InlineData(1, new string[] { "--NAME", "SOME_NAME", "--COUNT", "10", "--help" })]
	[InlineData(1, new string[] { "--help", "--COUNT", "10" })]
	[InlineData(1, new string[] { "--help" })]
	[InlineData(-1, new string[] { "--count", "--name" })]
	[InlineData(-1, new string[] { "WOW" })]
	[InlineData(-1, new string[] { })]
	public void ValidateTests(int answer, string[] test)
	{
		// Arrange, Act
        ValidateArguments valdiator = new();

		int result = valdiator.Validate(test);

		// Assert
		Assert.Equal<int>(answer, result);
	}
}