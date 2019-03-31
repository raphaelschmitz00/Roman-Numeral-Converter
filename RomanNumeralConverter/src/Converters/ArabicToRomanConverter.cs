using System.Collections.Generic;
using System.Text;
using RomanNumeralConverter.Converters.DigitConverters;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters
{
	public class ArabicToRomanConverter
	{
		public string Convert(int arabic)
		{
			List<IDigitConverter> digitConverters = CreateListOfDigitConverters();

			StringBuilder stringBuilder = new StringBuilder();
			foreach (IDigitConverter digitConverter in digitConverters)
			{
				string digitInRoman = digitConverter.GetRomanNumeralForPosition(arabic);
				stringBuilder.Append(digitInRoman);
			}

			return stringBuilder.ToString();
		}


		private List<IDigitConverter> CreateListOfDigitConverters()
		{
			List<IDigitConverter> digitConverters = new List<IDigitConverter>();
			digitConverters.Add(new SimpleDigitConverter(RomanDigit.M));
			digitConverters.Add(new EscalatingDigitConverter(RomanDigit.C, RomanDigit.D, RomanDigit.M));
			digitConverters.Add(new EscalatingDigitConverter(RomanDigit.X, RomanDigit.L, RomanDigit.C));
			digitConverters.Add(new EscalatingDigitConverter(RomanDigit.I, RomanDigit.V, RomanDigit.X));
			return digitConverters;
		}
	}
}