using System.Linq;
using RomanNumeralConverter.Converters.RomanToArabic;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.InputValidators
{
	public class RomanNumeralValidator : IRomanNumeralValidator
	{
		public bool IsARomanNumber(string input)
		{
			return input.All(IsARomanDigit);
		}


		private bool IsARomanDigit(char character)
		{
			return RomanDigit.All.Any(x => x.Letter == character);
		}
	}
}