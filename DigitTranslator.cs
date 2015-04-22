using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Randomizer
{
	public class DigitTranslator
	{
		static char[] allLettersArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
		static char[] zeroLettersArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
		static char[] twoLettersArray = "ABC".ToCharArray();
		static char[] threeLettersArray = "DEF".ToCharArray();
		static char[] fourLettersArray = "GHI".ToCharArray();
		static char[] fiveLettersArray = "JKL".ToCharArray();
		static char[] sixLettersArray = "MNO".ToCharArray();
		static char[] sevenLettersArray = "PQRS".ToCharArray();
		static char[] eightLettersArray = "TUV".ToCharArray();
		static char[] nineLettersArray = "WXYZ".ToCharArray();

		public DigitTranslator ()
		{
		}

		// Checking correct input
		public static bool isDigit(string s){
			bool errorCounter = Regex.IsMatch(s, @"[^0-9]");
			if (errorCounter == true) 
			{
				return false;
			}
			return true;
		}

		public static string toRandomString (string s)
		{
			return s.ToString ();
		}


		// Function to get random Numbers
		private static readonly Random randomNum = new Random();
		private static readonly object syncLock = new object();
		public static int GetRandomNumber(int min, int max)
		{
			lock(syncLock) { // synchronize
				return randomNum .Next(min, max);
			}
		}


		// Randomize algorithm
		public static string Randomize(string s)
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < s.Length; i++) {
				if (s[i] == '0') {
					result.Append (allLettersArray[GetRandomNumber (0, 26)].ToString ());
				} else if (s[i] == '1') {
					result.Append (allLettersArray[GetRandomNumber (0, 26)].ToString ());
				} else if (s[i] == '2') {
					result.Append (twoLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '3') {
					result.Append (threeLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '4') {
					result.Append (fourLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '5') {
					result.Append (fiveLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '6') {
					result.Append (sixLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '7') {
					result.Append (sevenLettersArray[GetRandomNumber (0, 4)].ToString ());
				} else if (s[i] == '8') {
					result.Append (eightLettersArray[GetRandomNumber (0, 3)].ToString ());
				} else if (s[i] == '9') {
					result.Append (nineLettersArray[GetRandomNumber (0, 4)].ToString ());
				}
			}

			return result.ToString();
		}
			
	}
}

