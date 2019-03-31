using NUnit.Framework;
using RomanNumeralConverter.InputValidators;


namespace RomanNumeralConverterUnitTests.InputValidators
{
	public class RomanNumeralValidatorTests
	{
		private RomanNumeralValidator _romanNumeralValidator;


		[SetUp]
		public void SetUp()
		{
			_romanNumeralValidator = new RomanNumeralValidator();
		}


		[Test]
		public void ThreeIsRecognized()
		{
			string inRoman = "III";

			bool result = _romanNumeralValidator.IsARomanNumber(inRoman);

			Assert.IsTrue(result);
		}


		[Test]
		public void CanConvertTwoHundredFortySix()
		{
			string inRoman = "CCXLVI";

			bool result = _romanNumeralValidator.IsARomanNumber(inRoman);

			Assert.IsTrue(result);
		}


		[Test]
		public void CanConvertOneThousandSevenHundredSeventySix()
		{
			string inRoman = "MDCCLXXVI";

			bool result = _romanNumeralValidator.IsARomanNumber(inRoman);

			Assert.IsTrue(result);
		}
	}
}