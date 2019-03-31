using RomanNumeralConverter.ArgumentParsers;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Converters.RomanToArabic;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters
{
	public class InputConverter
	{
		private readonly IArgumentParser _argumentParser;
		private readonly ArabicToRomanConverter _arabicToRomanConverter;
		private readonly RomanToArabicConverter _romanToArabicConverter;


		public InputConverter(IArgumentParser argumentParser, ArabicToRomanConverter arabicToRomanConverter,
			RomanToArabicConverter romanToArabicConverter)
		{
			_argumentParser = argumentParser;
			_arabicToRomanConverter = arabicToRomanConverter;
			_romanToArabicConverter = romanToArabicConverter;
		}


		public Attempt<string> Convert(string[] args)
		{
			Attempt<string> firstArgumentAttempt = _argumentParser.GetFirstArgument(args);
			if (firstArgumentAttempt.Failed) return firstArgumentAttempt;

			string firstArgument = firstArgumentAttempt.Result;
			Attempt<string> arabicAttempt = _arabicToRomanConverter.Convert(firstArgument);
			if (!arabicAttempt.Failed) return new Attempt<string>(arabicAttempt.Result);

			Attempt<int> romanAttempt = _romanToArabicConverter.Convert(firstArgument);
			if (!romanAttempt.Failed) return new Attempt<string>(romanAttempt.Result.ToString());

			return new Attempt<string>(ErrorRegistry.CantParseInput);
		}
	}
}