using System;
using System.Data;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter
{
	public class Program
	{
		public static int Main(string[] args)
		{
			InputConverterFactory inputConverterFactory = new InputConverterFactory();
			InputConverter inputConverter = inputConverterFactory.ComposeInputConverter();
			Attempt<string> attempt = inputConverter.Convert(args);
			if (attempt.Failed)
			{
				Console.WriteLine(attempt.Error.Message);
				return 1;
			}

			Console.WriteLine(attempt.Result);
			return 0;
		}
	}
}