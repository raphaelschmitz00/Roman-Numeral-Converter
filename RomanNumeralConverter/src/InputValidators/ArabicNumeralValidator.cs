using System;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.InputValidators
{
	public	class ArabicNumeralValidator : IArabicNumeralValidator
	{
		public Attempt<int> ConvertToArabicNumber(string input)
		{
			throw new NotImplementedException();
			
		}
	}
}