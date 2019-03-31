using System.Collections.Generic;


namespace RomanNumeralConverter.Units
{
	public class RomanDigit
	{
		public static readonly RomanDigit I = new RomanDigit('I', 1);
		public static readonly RomanDigit V = new RomanDigit('V', 5);
		public static readonly RomanDigit X = new RomanDigit('X', 10);
		public static readonly RomanDigit L = new RomanDigit('L', 50);
		public static readonly RomanDigit C = new RomanDigit('C', 100);
		public static readonly RomanDigit D = new RomanDigit('D', 500);
		public static readonly RomanDigit M = new RomanDigit('M', 1000);

		public static readonly List<RomanDigit> All = new List<RomanDigit> {I, V, X, L, C, D, M};


		private RomanDigit(char letter, int value)
		{
			Letter = letter;
			Value = value;
		}


		public char Letter { get; }
		public int Value { get; }
	}
}