using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Randomizer
{
	public class LetterTranslator
	{
		private static readonly Random randomNum = new Random();

		public LetterTranslator ()
		{
		}

		// Check if it's a string
		public static bool isString(string s){
			for (int i = 0; i < s.Length; i++) {
				if (Char.IsLetter (s [i]) == false) {
					return false;
				}
			}
			return true;
		}

		// Generate random string
		public static string RandomString(string inputString)
		{
			StringBuilder finalString = new StringBuilder();
			char ch;
			for (int i = 0; i < inputString.Length; i++)
			{
				ch = inputString[randomNum.Next(0, inputString.Length)];
				finalString.Append(ch);
			}
			return finalString.ToString();
		}
	}
}

