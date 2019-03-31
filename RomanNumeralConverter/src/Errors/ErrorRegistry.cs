namespace RomanNumeralConverter.Errors
{
	public static class ErrorRegistry
	{
		public static readonly Error NoArgument = new Error("No Argument!");
		public static readonly Error TooManyArguments = new Error("Too many Argument!");
		public static readonly Error NotAnArabicNumber = new Error("Not an arabic number!");
		public static readonly Error NotARomanNumeral = new Error("Not a roman numeral!");
		public static readonly Error CantParseInput = new Error("Can't parse input!");
	}
}