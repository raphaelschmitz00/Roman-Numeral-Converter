using NUnit.Framework;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.Errors
{
	public class ErrorTests
	{
		[Test]
		public void PredefinedNoneErrorCountsAsNone()
		{
			Error error = Error.None;
			bool isNone = error.IsNone;

			Assert.IsTrue(isNone);
		}


		[Test]
		public void NewErrorDoesNotCountsAsNone()
		{
			Error error = new Error("Bad thing Happened!");
			bool isNone = error.IsNone;

			Assert.IsFalse(isNone);
		}


		[Test]
		public void MessageIsPassedCorrectly()
		{
			string message = "Bad thing Happened!";
			Error error = new Error(message);
			string errorMessage = error.Message;

			Assert.AreEqual(message, errorMessage);
		}
	}
}