namespace Codility.Tests;

public class ParkingCostTests
{

	[Theory]
	[InlineData("10:00", "13:21", 17)]
	[InlineData("9:42", "11:42", 9)]
	[InlineData("10:00", "11:00", 5)]
	[InlineData("10:00", "10:30", 5)]
	[InlineData("18:21", "18:29", 5)]
	public void ParkingCost_(string enterTime, string exitTime, int answer)
	{
		// Arrange, Act
		int result = 0;

        result = ParkingCost.Solution(enterTime, exitTime);

		// Assert
		Assert.Equal<int>(answer, result);
	}
}