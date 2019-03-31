using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters.RomanToArabic
{
	public interface IValueGatherer
	{
		void Reset();
		void Add(RomanDigit romanDigit);
		int GetValue();
	}
}