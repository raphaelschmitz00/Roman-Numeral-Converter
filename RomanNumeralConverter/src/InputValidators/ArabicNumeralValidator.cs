using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.InputValidators
{
	public class ArabicNumeralValidator : IArabicNumeralValidator
	{
		public Attempt<int> ConvertToArabicNumber(string input)
		{
			int intValue;
			bool itWorked = int.TryParse(input, out intValue);
			if (itWorked) return new Attempt<int>(intValue);
			Error error = new Error("Not an arabic number!");
			return new Attempt<int>(error);
		}
	}
}