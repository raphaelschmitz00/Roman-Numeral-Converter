using NUnit.Framework;
using RomanNumeralConverter.ArgumentParsers;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.ArgumentParsers
{
	public class ArgumentParserTests
	{
		private ArgumentParser _argumentParser;


		[SetUp]
		public void SetUp()
		{
			_argumentParser = new ArgumentParser();
		}


		[Test]
		public void SingleArgumentIsAccepted()
		{
			Attempt<string> attempt = _argumentParser.GetFirstArgument("");

			bool result = attempt.Failed;

			Assert.IsFalse(result);
		}


		[Test]
		public void SingleArgumentIsPassedOnCorrectly()
		{
			string argument = "boop";
			Attempt<string> attempt = _argumentParser.GetFirstArgument(argument);

			string result = attempt.Result;

			Assert.AreEqual(argument, result);
		}


		[Test]
		public void NoArgumentIsRejected()
		{
			Attempt<string> attempt = _argumentParser.GetFirstArgument();

			bool result = attempt.Failed;

			Assert.IsTrue(result);
		}


		[Test]
		public void TwoArgumentsIsRejected()
		{
			Attempt<string> attempt = _argumentParser.GetFirstArgument("", "");

			bool result = attempt.Failed;

			Assert.IsTrue(result);
		}
	}
}