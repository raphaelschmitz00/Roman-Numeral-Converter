using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.ArgumentParsers
{
	public interface IArgumentParser
	{
		Attempt<string> GetFirstArgument(string[] args);
	}
}