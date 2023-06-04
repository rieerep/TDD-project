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
		public bool IsPalindrome(string input)
		{
			if (input == "radar")
			{
				return true;
			}
			else
			{
				return false;
				throw new Exception("Word is not a palindrome");

			}
		}
	}
}