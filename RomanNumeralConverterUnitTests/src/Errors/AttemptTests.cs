using NUnit.Framework;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.Errors
{
	public class AttemptTests
	{
		[Test]
		public void AttemptWithErrorCountsAsFailed()
		{
			string message = "Bad thing Happened!";
			Error error = new Error(message);
			Attempt<string> attempt = new Attempt<string>(error);

			bool failed = attempt.Failed;

			Assert.IsTrue(failed);
		}


		[Test]
		public void ErrorIsPassedOnCorrectly()
		{
			string message = "Bad thing Happened!";
			Error error = new Error(message);
			Attempt<string> attempt = new Attempt<string>(error);

			Error result = attempt.Error;

			Assert.AreEqual(error, result);
		}


		[Test]
		public void AttemptWithNoneErrorDoesNotCountAsFailed()
		{
			string message = "Bad thing Happened!";
			Attempt<string> attempt = new Attempt<string>(message);

			bool failed = attempt.Failed;

			Assert.IsFalse(failed);
		}


		[Test]
		public void SuccessValueIsPassedOnCorrectly()
		{
			string message = "Bad thing Happened!";
			Attempt<string> attempt = new Attempt<string>(message);

			string result = attempt.Result;

			Assert.AreEqual(message, result);
		}
	}
}