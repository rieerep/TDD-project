namespace WordLib
{
	public class WordLib
	{
		private readonly string wordOne;
		public string word;

		public WordLib(string wordOne) 
		{
			this.wordOne = wordOne;
		}
	}

	public class Worder
	{
		public int CountLetters(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				throw new ArgumentException("Input is empty");
			} else
			return input.Length;
		}

		public int CountWords(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				throw new ArgumentException("Input is empty");
			}
			return input.Split(' ').Length;

		}

		public bool IsPalindrome(string input)
		{
			string inputString = input;
			char[] inputArray = inputString.ToCharArray();
			Array.Reverse(inputArray);
			string reversedArray = new string(inputArray);

			if (string.IsNullOrEmpty(inputString))
			{
				throw new ArgumentException("Input is empty");
			}
			else if (reversedArray == input)
			{
				return true;
			}
			else
			{
				return false;
				throw new Exception("Word is not a palindrome");

			}
		}

		public int WordLength(string input)
		{
			string letters = input;

			int length = letters.Length;

			return length;
		}
	}
}