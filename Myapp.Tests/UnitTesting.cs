using Xunit;
using MyApp.Application.Services;
namespace Myapp.Tests
{
	public class CalculatorServiceTests
	{
		//[Fact]
		//public void Add_TwoNumbers_ReturnsCorrectSum()
		//{
		//	// Arrange
		//	var svc = new CalculatorService(2,4);

		//	// Act
		//	var result = svc.Add();

		//	// Assert
		//	Assert.Equal(6, result);
		//}
		[Theory]
		[InlineData(2, 3, 5)]
		[InlineData(10, 20, 30)]
		[InlineData(-1, 1, 0)]
		public void AddNumbers_ReturnsCorrectSum(int a, int b, int expected)
		{
			// Arrange
			var svc = new CalculatorService(a, b);

			// Act
			var result = svc.Add();

			// Assert
			Assert.Equal(expected, result);
		}

	}
}
//Staging