using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters.ArabicToRoman
{
	public class ArabicToRomanConverter
	{
		private readonly IArabicNumeralValidator _arabicNumeralValidator;
		private readonly IDigitConverterList _digitConverterList;


		public ArabicToRomanConverter(IArabicNumeralValidator arabicNumeralValidator,
			IDigitConverterList digitConverterList)
		{
			_arabicNumeralValidator = arabicNumeralValidator;
			_digitConverterList = digitConverterList;
		}


		public Attempt<string> Convert(string input)
		{
			Attempt<int> attempt = _arabicNumeralValidator.ConvertToArabicNumber(input);
			if (attempt.Failed) return new Attempt<string>(attempt.Error);

			int arabicNumber = attempt.Result;
			string result = _digitConverterList.Convert(arabicNumber);
			return new Attempt<string>(result);
		}
	}
}