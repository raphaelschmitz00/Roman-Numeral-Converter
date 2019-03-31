using System.Linq;
using RomanNumeralConverter.Errors;
using RomanNumeralConverter.Units;


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


		public Attempt<int> Convert(string input)
		{
			bool isARomanNumber = _romanNumeralValidator.IsARomanNumber(input);
			if (!isARomanNumber) return new Attempt<int>(new Error("Not a roman numeral!"));

			_valueGatherer.Reset();
			foreach (char character in input)
			{
				RomanDigit romanDigit = RomanDigit.All.First(x => x.Letter == character);
				_valueGatherer.Add(romanDigit);
			}

			int result = _valueGatherer.GetValue();
			return new Attempt<int>(result);
		}
	}
}