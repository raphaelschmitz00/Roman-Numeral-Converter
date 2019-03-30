using System.Collections.Generic;
using System.Linq;


namespace RomanNumeralConverter.Units
{
	public class RomanNumeral
	{
		private readonly List<RomanNumeralLetter> _letters;


		public RomanNumeral(List<RomanNumeralLetter> letters)
		{
			_letters = letters;
		}


		public List<RomanNumeralLetter> Letters => _letters.ToList();
	}
}