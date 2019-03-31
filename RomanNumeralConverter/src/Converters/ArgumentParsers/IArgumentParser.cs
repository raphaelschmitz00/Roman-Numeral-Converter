using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.Converters.ArgumentParsers
{
	public interface IArgumentParser
	{
		Attempt<string> GetFirstArgument(string[] args);
	}
}