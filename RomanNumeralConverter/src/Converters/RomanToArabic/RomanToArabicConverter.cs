using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters.RomanToArabic
{
	public class RomanToArabicConverter
	{
		private readonly IRomanNumeralValidator _romanNumeralValidator;
		private readonly IValueGatherer _valueGatherer;


		public RomanToArabicConverter(IRomanNumeralValidator romanNumeralValidator, IValueGatherer valueGatherer)
		{
			_romanNumeralValidator = romanNumeralValidator;
			_valueGatherer = valueGatherer;
		}


		public Attempt<int> Convert(string roman)
		{
			throw new System.NotImplementedException();
		}
	}
}