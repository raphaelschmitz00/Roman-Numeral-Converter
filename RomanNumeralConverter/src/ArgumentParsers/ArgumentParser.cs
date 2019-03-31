using RomanNumeralConverter.Errors;


namespace RomanNumeralConverter.ArgumentParsers
{
	public class ArgumentParser : IArgumentParser
	{
		public Attempt<string> GetFirstArgument(params string[] args)
		{
			if (args.Length == 0) return new Attempt<string>(ErrorRegistry.NoArgument);
			if (args.Length > 1) return new Attempt<string>(ErrorRegistry.TooManyArguments);
			string argument = args[0];
			return new Attempt<string>(argument);
		}
	}
}