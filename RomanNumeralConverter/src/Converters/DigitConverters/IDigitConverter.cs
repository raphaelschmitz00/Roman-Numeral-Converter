namespace RomanNumeralConverter.Converters.DigitConverters
{
	public interface IDigitConverter
	{
		int Position { get; }
		string GetRomanNumeralForPosition(int digit);
	}
}