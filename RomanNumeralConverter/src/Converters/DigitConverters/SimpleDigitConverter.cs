using System.Text;
using RomanNumeralConverter.Units;
using RomanNumeralConverter.Utilities;


namespace RomanNumeralConverter.Converters.DigitConverters
{
	public class SimpleDigitConverter : IDigitConverter
	{
		private readonly RomanDigit _romanDigit;


		public SimpleDigitConverter(RomanDigit romanDigit)
		{
			_romanDigit = Validate.NotNull(romanDigit);
		}


		public int Position => _romanDigit.Value;


		public string GetRomanNumeralForPosition(int number)
		{
			int digit = number / Position % 10;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < digit; i++)
			{
				stringBuilder.Append(_romanDigit.Letter);
			}

			return stringBuilder.ToString();
		}
	}
}