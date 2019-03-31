using System.Collections.Generic;
using System.Linq;
using RomanNumeralConverter.Utilities;


namespace RomanNumeralConverter.Units
{
	public class RomanNumeral
	{
		private readonly List<RomanDigit> _letters;


		public RomanNumeral(List<RomanDigit> letters)
		{
			_letters = Validate.NotNull(letters);
		}


		public List<RomanDigit> Letters => _letters.ToList();
	}
}