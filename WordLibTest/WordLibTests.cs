using WordLib;
namespace WordLibTest
{
	[TestClass]
	public class WordLibTests
	{
		[TestMethod]
		public void TestPalindrome_whenGivenPalindrome_returnsTrue()
		{

			//Arrange
			string input = "radar";
			bool expectedResult = true;

			Worder worder1 = new Worder ();

			// Act
			bool actualResult = worder1.IsPalindrome(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);

		}
		[TestMethod]
		public void TestPalindrome_whenGivenNonePalindrome_returnsFalse_ShouldThrowArgument()
		{
			//Arrange
			string input = "boat";
			bool expectedResult = false;

			Worder worder2 = new Worder();

			// Act
			bool actualResult = worder2.IsPalindrome(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
			// Assert.ThrowsException<ArgumentException>(() => worder2.IsPalindrome(input)/*expectedResult, actualResult*/);
		}
	}
}