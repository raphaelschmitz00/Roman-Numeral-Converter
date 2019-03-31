using NUnit.Framework;
using RomanNumeralConverter.Converters.DigitConverters;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Converters.DigitConverters
{
	public class EscalatingDigitConverterTests
	{
		private EscalatingDigitConverter _escalatingDigitConverter;


		[SetUp]
		public void SetUp()
		{
			_escalatingDigitConverter = new EscalatingDigitConverter(
				RomanDigit.I, RomanDigit.V, RomanDigit.X);
		}


		[Test]
		public void CanConvertThree()
		{
			string threeInRoman = _escalatingDigitConverter.GetRomanNumeralForPosition(3);

			Assert.AreEqual("III", threeInRoman);
		}


		[Test]
		public void CanConvertFour()
		{
			string inRoman = _escalatingDigitConverter.GetRomanNumeralForPosition(4);

			Assert.AreEqual("IV", inRoman);
		}


		[Test]
		public void CanConvertSix()
		{
			string inRoman = _escalatingDigitConverter.GetRomanNumeralForPosition(6);

			Assert.AreEqual("VI", inRoman);
		}


		[Test]
		public void CanConvertNine()
		{
			string inRoman = _escalatingDigitConverter.GetRomanNumeralForPosition(9);

			Assert.AreEqual("IX", inRoman);
		}


		[Test]
		public void CanConvertOtherDigitPositions()
		{
			EscalatingDigitConverter hundredDigitConverter = new EscalatingDigitConverter(
				RomanDigit.C, RomanDigit.D, RomanDigit.M);
			string inRoman = hundredDigitConverter.GetRomanNumeralForPosition(345);

			Assert.AreEqual("CCC", inRoman);
		}
	}
}