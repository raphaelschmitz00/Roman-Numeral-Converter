using NUnit.Framework;
using RomanNumeralConverter.Converters;


namespace RomanNumeralConverterUnitTests.Converters
{
	public class ArabicToRomanConverterTests
	{
		private ArabicToRomanConverter _arabicToRomanConverter;


		[SetUp]
		public void SetUp()
		{
			_arabicToRomanConverter = new ArabicToRomanConverter();
		}


		[Test]
		public void CanConvertThree()
		{
			string threeInRoman = _arabicToRomanConverter.Convert(3);

			Assert.AreEqual("III", threeInRoman);
		}


		[Test]
		public void CanConvertFour()
		{
			string inRoman = _arabicToRomanConverter.Convert(4);

			Assert.AreEqual("IV", inRoman);
		}


		[Test]
		public void CanConvertSix()
		{
			string inRoman = _arabicToRomanConverter.Convert(6);

			Assert.AreEqual("VI", inRoman);
		}


		[Test]
		public void CanConvertNine()
		{
			string inRoman = _arabicToRomanConverter.Convert(9);

			Assert.AreEqual("IX", inRoman);
		}


		[Test]
		public void CanConvertTwelve()
		{
			string inRoman = _arabicToRomanConverter.Convert(12);

			Assert.AreEqual("XII", inRoman);
		}


		[Test]
		public void CanConvertThirtyNine()
		{
			string inRoman = _arabicToRomanConverter.Convert(39);

			Assert.AreEqual("XXXIX.", inRoman);
		}


		[Test]
		public void CanConvertOneHundredSixty()
		{
			string inRoman = _arabicToRomanConverter.Convert(160);

			Assert.AreEqual("CLX", inRoman);
		}


		[Test]
		public void CanConvertTwoHundredSeven()
		{
			string inRoman = _arabicToRomanConverter.Convert(207);

			Assert.AreEqual(" CCVII", inRoman);
		}


		[Test]
		public void CanConvertTwoHundredFortySix()
		{
			string inRoman = _arabicToRomanConverter.Convert(246);

			Assert.AreEqual("CCXLVI", inRoman);
		}


		[Test]
		public void CanConvertFourHundredTwentyOne()
		{
			string inRoman = _arabicToRomanConverter.Convert(421);

			Assert.AreEqual("CDXXI", inRoman);
		}


		[Test]
		public void CanConvertOneThousandSixtySix()
		{
			string inRoman = _arabicToRomanConverter.Convert(1066);

			Assert.AreEqual("MLXVI", inRoman);
		}


		[Test]
		public void CanConvertOneThousandSevenHundredSeventySix()
		{
			string inRoman = _arabicToRomanConverter.Convert(1776);

			Assert.AreEqual("MDCCLXXVI", inRoman);
		}


		[Test]
		public void CanConvertOneThousandNineHundredFiftyFour()
		{
			string inRoman = _arabicToRomanConverter.Convert(1954);

			Assert.AreEqual("MCMLIV", inRoman);
		}


		[Test]
		public void CanConvertOneThousandNineHundredNinety()
		{
			string inRoman = _arabicToRomanConverter.Convert(1990);

			Assert.AreEqual("MCMXC", inRoman);
		}


		[Test]
		public void CanConvertTwoThousandFourteen()
		{
			string inRoman = _arabicToRomanConverter.Convert(2014);

			Assert.AreEqual("MMXIV", inRoman);
		}


		[Test]
		public void CanConvertTwoThousandNineteen()
		{
			string inRoman = _arabicToRomanConverter.Convert(2019);

			Assert.AreEqual("MMXIX", inRoman);
		}
	}
}