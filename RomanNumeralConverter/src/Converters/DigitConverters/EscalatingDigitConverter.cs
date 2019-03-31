using RomanNumeralConverter.Units;
using RomanNumeralConverter.Utilities;


namespace RomanNumeralConverter.Converters.DigitConverters
{
	public class EscalatingDigitConverter : IDigitConverter
	{
		private readonly RomanDigit _letterForValueOfOne;
		private readonly RomanDigit _letterForValueOfFive;
		private readonly RomanDigit _letterForValueOfTen;


		public EscalatingDigitConverter(RomanDigit letterForValueOfOne,
			RomanDigit letterForValueOfFive, RomanDigit letterForValueOfTen)
		{
			_letterForValueOfOne = Validate.NotNull(letterForValueOfOne);
			_letterForValueOfFive = Validate.NotNull(letterForValueOfFive);
			_letterForValueOfTen = Validate.NotNull(letterForValueOfTen);
		}


		public int Position => _letterForValueOfOne.Value;


		public string GetRomanNumeralForPosition(int number)
		{
			int digit = number / _letterForValueOfOne.Value % 10;
			if (digit == 9) return string.Format("{0}{1}", _letterForValueOfOne.Letter, _letterForValueOfTen.Letter);
			if (digit == 4) return string.Format("{0}{1}", _letterForValueOfOne.Letter, _letterForValueOfFive.Letter);
			return ComposeValueWithoutSubtractiveNotation(digit);
		}


		private string ComposeValueWithoutSubtractiveNotation(int digit)
		{
			string result = "";
			if (digit >= 5)
			{
				result += _letterForValueOfFive.Letter;
				digit -= 5;
			}

			for (int i = 0; i < digit; i++)
			{
				result += _letterForValueOfOne.Letter;
			}

			return result;
		}
	}
}