using System;
using NUnit.Framework;
using RomanNumeralConverter.Utilities;


namespace RomanNumeralConverterUnitTests.Utilities
{
	public class ValidateTests
	{
		[Test]
		public void NotNullThrowsForNull()
		{
			Assert.Throws<ArgumentNullException>(() => Validate.NotNull<string>(null));
		}


		[Test]
		public void NotNullDoesNotThrowForNotNull()
		{
			string message = "the message";

			Assert.DoesNotThrow(() => Validate.NotNull(message));
		}


		[Test]
		public void ValueIsPassedOnCorrectly()
		{
			string message = "the message";

			string result = Validate.NotNull(message);

			Assert.AreEqual(message, result);
		}
	}
}