using System;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverter
{
	public class InputConverterFactory
	{
		public InputConverter ComposeInputConverter()
		{
			throw new NotImplementedException();
		}


		public DigitConverterList CreateListOfDigitConverters()
		{
			DigitConverterList digitConverterList = new DigitConverterList();
			digitConverterList.Add(new SimpleDigitConverter(RomanDigit.M));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.C, RomanDigit.D, RomanDigit.M));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.X, RomanDigit.L, RomanDigit.C));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.I, RomanDigit.V, RomanDigit.X));
			return digitConverterList;
		}
	}
}