using NUnit.Framework;
using RomanNumeralConverter.Errors;
using RomanNumeralConverter.InputValidators;


namespace RomanNumeralConverterUnitTests.InputValidators
{
	public class ArabicNumeralValidatorTests
	{
		private ArabicNumeralValidator _arabicNumeralValidator;


		[SetUp]
		public void SetUp()
		{
			_arabicNumeralValidator = new ArabicNumeralValidator();
		}


		[Test]
		public void IntIsAccepted()
		{
			Attempt<int> attempt = _arabicNumeralValidator.ConvertToArabicNumber("1234");

			Assert.IsFalse(attempt.Failed);
		}


		[Test]
		public void IntIsConvertedCorrectly()
		{
			Attempt<int> attempt = _arabicNumeralValidator.ConvertToArabicNumber("1234");

			Assert.AreEqual(1234, attempt.Result);
		}


		[Test]
		public void LettersAreRejected()
		{
			Attempt<int> attempt = _arabicNumeralValidator.ConvertToArabicNumber("1234a");

			Assert.IsTrue(attempt.Failed);
		}


		[Test]
		public void SpecialCharsAreRejected()
		{
			Attempt<int> attempt = _arabicNumeralValidator.ConvertToArabicNumber("1234!");

			Assert.IsTrue(attempt.Failed);
		}
	}
}