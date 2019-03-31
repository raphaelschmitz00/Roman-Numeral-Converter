using NUnit.Framework;
using RomanNumeralConverter;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterIntegrationTests
{
	public class RomanToArabicTests
	{
		private InputConverter _inputConverter;


		[SetUp]
		public void SetUp()
		{
			InputConverterFactory inputConverterFactory = new InputConverterFactory();
			_inputConverter = inputConverterFactory.ComposeInputConverter();
		}


		[Test]
		public void RomanNumeralCharacterCausesSuccessfullAttempt()
		{
			string[] inRoman = {"III"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.IsFalse(result.Failed);
		}


		[Test]
		public void NonRomanNumeralCharacterCausesFailedAttempt()
		{
			string[] inRoman = {"IIIQ"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.IsTrue(result.Failed);
		}


		[Test]
		public void CanConvertThree()
		{
			string[] inRoman = {"III"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("3", result.Result);
		}


		[Test]
		public void CanConvertFour()
		{
			string[] inRoman = {"IV"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("4", result.Result);
		}


		[Test]
		public void CanConvertSix()
		{
			string[] inRoman = {"VI"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("6", result.Result);
		}


		[Test]
		public void CanConvertNine()
		{
			string[] inRoman = {"IX"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("9", result.Result);
		}


		[Test]
		public void CanConvertTwelve()
		{
			string[] inRoman = {"XII"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("12", result.Result);
		}


		[Test]
		public void CanConvertThirtyNine()
		{
			string[] inRoman = {"XXXIX"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("39", result.Result);
		}


		[Test]
		public void CanConvertOneHundredSixty()
		{
			string[] inRoman = {"CLX"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("160", result.Result);
		}


		[Test]
		public void CanConvertTwoHundredSeven()
		{
			string[] inRoman = {"CCVII"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("207", result.Result);
		}


		[Test]
		public void CanConvertTwoHundredFortySix()
		{
			string[] inRoman = {"CCXLVI"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("246", result.Result);
		}


		[Test]
		public void CanConvertFourHundredTwentyOne()
		{
			string[] inRoman = {"CDXXI"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("421", result.Result);
		}


		[Test]
		public void CanConvertOneThousandSixtySix()
		{
			string[] inRoman = {"MLXVI"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("1066", result.Result);
		}


		[Test]
		public void CanConvertOneThousandSevenHundredSeventySix()
		{
			string[] inRoman = {"MDCCLXXVI"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("1776", result.Result);
		}


		[Test]
		public void CanConvertOneThousandNineHundredFiftyFour()
		{
			string[] inRoman = {"MCMLIV"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("1954", result.Result);
		}


		[Test]
		public void CanConvertOneThousandNineHundredNinety()
		{
			string[] inRoman = {"MCMXC"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("1990", result.Result);
		}


		[Test]
		public void CanConvertTwoThousandFourteen()
		{
			string[] inRoman = {"MMXIV"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("2014", result.Result);
		}


		[Test]
		public void CanConvertTwoThousandNineteen()
		{
			string[] inRoman = {"MMXIX"};

			Attempt<string> result = _inputConverter.Convert(inRoman);

			Assert.AreEqual("2019", result.Result);
		}
	}
}