using RomanNumeralConverter.ArgumentParsers;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Converters.RomanToArabic;
using RomanNumeralConverter.InputValidators;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverter
{
	public class InputConverterFactory
	{
		public InputConverter ComposeInputConverter()
		{
			IArgumentParser argumentParser = new ArgumentParser();
			ArabicToRomanConverter arabicToRomanConverter = CreateArabicToRomanConverter();
			RomanToArabicConverter romanToArabicConverter = CreateRomanToArabicConverter();
			return new InputConverter(argumentParser, arabicToRomanConverter, romanToArabicConverter);
		}


		private ArabicToRomanConverter CreateArabicToRomanConverter()
		{
			IArabicNumeralValidator arabicNumeralValidator = new ArabicNumeralValidator();
			DigitConverterList digitConverterList = CreateDigitConverterList();
			return new ArabicToRomanConverter(arabicNumeralValidator, digitConverterList);
		}


		private RomanToArabicConverter CreateRomanToArabicConverter()
		{
			IRomanNumeralValidator romanNumeralValidator = new RomanNumeralValidator();
			IValueGatherer valueGatherer = new ValueGatherer();
			return new RomanToArabicConverter(romanNumeralValidator, valueGatherer);
		}


		private DigitConverterList CreateDigitConverterList()
		{
			DigitConverterList digitConverterList = new DigitConverterList();
			digitConverterList.Add(new SimpleDigitConverter(RomanDigit.M));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.C, RomanDigit.D, RomanDigit.M));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.X, RomanDigit.L, RomanDigit.C));
			digitConverterList.Add(new EscalatingDigitConverter(RomanDigit.I, RomanDigit.V, RomanDigit.X));
			return digitConverterList;
		}
	}
}