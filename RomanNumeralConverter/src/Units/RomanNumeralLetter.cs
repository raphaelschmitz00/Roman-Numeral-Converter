namespace RomanNumeralConverter.Units
{
	public class RomanNumeralLetter
	{
		public static readonly RomanNumeralLetter I = new RomanNumeralLetter('I', 1);
		public static readonly RomanNumeralLetter V = new RomanNumeralLetter('V', 5);
		public static readonly RomanNumeralLetter X = new RomanNumeralLetter('X', 10);
		public static readonly RomanNumeralLetter L = new RomanNumeralLetter('L', 50);
		public static readonly RomanNumeralLetter C = new RomanNumeralLetter('C', 100);
		public static readonly RomanNumeralLetter D = new RomanNumeralLetter('D', 500);
		public static readonly RomanNumeralLetter M = new RomanNumeralLetter('M', 1000);


		private RomanNumeralLetter(char letter, int value)
		{
			Letter = letter;
			Value = value;
		}


		public char Letter { get; }
		public int Value { get; }


		public static bool operator <(RomanNumeralLetter left, RomanNumeralLetter right)
		{
			return left.CompareTo(right) < 0;
		}


		public static bool operator >(RomanNumeralLetter left, RomanNumeralLetter right)
		{
			return left.CompareTo(right) > 0;
		}


		private int CompareTo(RomanNumeralLetter other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			return Value.CompareTo(other.Value);
		}
	}
}