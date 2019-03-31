namespace RomanNumeralConverter.Converters.ArabicToRoman
{
	public interface IDigitConverter
	{
		int Position { get; }
		string GetRomanNumeralForPosition(int digit);
	}
}