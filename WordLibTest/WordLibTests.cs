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

		[TestMethod]
		public void NullOrEmpty_IfInputIsEmptyOrNull_ShouldThrowArgumentIfEmpty()
		{
			//Arrange
			string input = "";

			Worder worder3 = new Worder();

			// Act

			// Assert
			// Assert.AreEqual(expectedResult, actualResult);
			Assert.ThrowsException<ArgumentException>(() => worder3.IsPalindrome(input)/*expectedResult, actualResult*/);
			//Assert.ThrowsException<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-1));

		}

		[TestMethod]
		public void CountLetters_WhenCalMethodShouldCountLetters()
		{
			// Arrange
			string input = "Screeching";
			int expectedResult = 10;

			Worder worder4 = new Worder();

			// Act
			int actualResult = worder4.CountLetters(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);

		}

		[TestMethod]
		public void CountLetters_WhenCalledWithShortWord()
		{
			// Arrange
			string input = "Fish";
			int expectedResult = 4;

			Worder worder4 = new Worder();

			// Act
			int actualResult = worder4.CountLetters(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);

		}

		[TestMethod]

		public void NullOrEmpty_CountWordIsEmptyOrNull_ShouldThrowArgumentIfEmpty()
		{
			// Arrange
			string input = "";

			Worder worder5 = new Worder();

			// Act & Assert
			Assert.ThrowsException<ArgumentException>(() => worder5.CountLetters(input)/*expectedResult, actualResult*/);

		}

		[TestMethod]
		public void CountWords_WhenCalledCountWordsInASentence_ReturnNumberOfWords()
		{
			// Arrange
			string input = "A schreeching bike ran over the old lady";
			int expectedResult = 8;

			Worder worder4 = new Worder();

			// Act
			int actualResult = worder4.CountWords(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);

		}

		[TestMethod]
		public void CountWords_WhenCalledCountWordsInAnotherSentence_ReturnNumberOfWords()
		{
			// Arrange
			string input = "A Quick brown fox";
			int expectedResult = 4;

			Worder worder4 = new Worder();

			// Act
			int actualResult = worder4.CountWords(input);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);

		}

	}
}