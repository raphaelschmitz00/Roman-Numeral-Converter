using System;
using System.Collections.Generic;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters.ArabicToRoman
{
	public class ArabicToRomanConverterFactory
	{
		public ArabicToRomanConverter Create()
		{
			throw new NotImplementedException();
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