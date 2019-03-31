using NUnit.Framework;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Converters.ArabicToRoman
{
	public class SimpleDigitConverterTests
	{
		private SimpleDigitConverter _simpleDigitConverter;


		[SetUp]
		public void SetUp()
		{
			_simpleDigitConverter = new SimpleDigitConverter(RomanDigit.M);
		}


		[Test]
		public void CorrectlyConvertsOneThousand()
		{
			string inRoman = _simpleDigitConverter.GetRomanNumeralForPosition(1000);

			Assert.AreEqual("M", inRoman);
		}


		[Test]
		public void CorrectlyConvertsThreeThousand()
		{
			string inRoman = _simpleDigitConverter.GetRomanNumeralForPosition(3000);

			Assert.AreEqual("MMM", inRoman);
		}

		[Test]
		public void ReturnsEmptyStringForSmallerNumbers()
		{
			string inRoman = _simpleDigitConverter.GetRomanNumeralForPosition(123);

			Assert.AreEqual("", inRoman);
		}
		[Test]
		public void IgnoresDigitsBelow()
		{
			string inRoman = _simpleDigitConverter.GetRomanNumeralForPosition(1234);

			Assert.AreEqual("M", inRoman);
		}


	}
}