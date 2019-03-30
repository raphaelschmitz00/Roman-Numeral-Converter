using NUnit.Framework;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.Converters
{
	public class RomanToArabicConverterTests
	{
		[Test]
		public void NonRomanNumeralCharacterCausesFailedAttempt()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "IIIQ";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.IsTrue(result.Failed);
		}


		[Test]
		public void CanConvertThree()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "III";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.AreEqual(3, result.Result);
		}


		[Test]
		public void CanConvertFour()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "IV";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.AreEqual(4, result.Result);
		}


		[Test]
		public void CanConvertSix()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "VI";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.AreEqual(6, result.Result);
		}


		[Test]
		public void CanConvertNine()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "IX";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.AreEqual(9, result.Result);
		}


		[Test]
		public void CanConvertTwelve()
		{
			RomanToArabicConverter romanToArabicConverter = new RomanToArabicConverter();
			string inRoman = "XII";

			Attempt<int> result = romanToArabicConverter.Convert(inRoman);

			Assert.AreEqual(12, result.Result);
		}
	}
}