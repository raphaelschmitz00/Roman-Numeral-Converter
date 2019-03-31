using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters.RomanToArabic
{
	public interface IRomanNumeralValidator
	{
		Attempt<string> ConvertToRomanNumber(string input);
	}
}