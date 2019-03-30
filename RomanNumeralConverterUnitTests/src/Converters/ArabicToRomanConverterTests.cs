using NUnit.Framework;
using RomanNumeralConverter.Converters;


namespace RomanNumeralConverterUnitTests.Converters
{
	public class ArabicToRomanConverterTests
	{
		[Test]
		public void CanConvertThree()
		{
			ArabicToRomanConverter arabicToRomanConverter = new ArabicToRomanConverter();

			string threeInRoman = arabicToRomanConverter.Convert(3);

			Assert.AreEqual("III", threeInRoman);
		}


		[Test]
		public void CanConvertFour()
		{
			ArabicToRomanConverter arabicToRomanConverter = new ArabicToRomanConverter();

			string inRoman = arabicToRomanConverter.Convert(4);

			Assert.AreEqual("IV", inRoman);
		}


		[Test]
		public void CanConvertSix()
		{
			ArabicToRomanConverter arabicToRomanConverter = new ArabicToRomanConverter();

			string inRoman = arabicToRomanConverter.Convert(6);

			Assert.AreEqual("VI", inRoman);
		}


		[Test]
		public void CanConvertNine()
		{
			ArabicToRomanConverter arabicToRomanConverter = new ArabicToRomanConverter();

			string inRoman = arabicToRomanConverter.Convert(9);

			Assert.AreEqual("IX", inRoman);
		}


		[Test]
		public void CanConvertTwelve()
		{
			ArabicToRomanConverter arabicToRomanConverter = new ArabicToRomanConverter();

			string inRoman = arabicToRomanConverter.Convert(12);

			Assert.AreEqual("XII", inRoman);
		}
	}
}