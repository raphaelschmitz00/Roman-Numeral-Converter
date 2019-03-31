using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters.ArabicToRoman
{
	public interface IArabicNumeralValidator
	{
		Attempt<int> ConvertToArabicNumber(string input);
	}
}