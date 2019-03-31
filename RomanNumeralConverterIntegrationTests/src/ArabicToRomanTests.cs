using NUnit.Framework;
using RomanNumeralConverter;
using RomanNumeralConverter.Converters;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterIntegrationTests
{
	public class ArabicToRomanTests
	{
		private InputConverter _inputConverter;


		[SetUp]
		public void SetUp()
		{
			InputConverterFactory inputConverterFactory = new InputConverterFactory();
			_inputConverter = inputConverterFactory.ComposeInputConverter();
		}


		[Test]
		public void CanConvertThree()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"3"});

			Assert.AreEqual("III", inRoman.Result);
		}


		[Test]
		public void CanConvertFour()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"4"});

			Assert.AreEqual("IV", inRoman.Result);
		}


		[Test]
		public void CanConvertSix()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"6"});

			Assert.AreEqual("VI", inRoman.Result);
		}


		[Test]
		public void CanConvertNine()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"9"});

			Assert.AreEqual("IX", inRoman.Result);
		}


		[Test]
		public void CanConvertTwelve()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"12"});

			Assert.AreEqual("XII", inRoman.Result);
		}


		[Test]
		public void CanConvertThirtyNine()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"39"});

			Assert.AreEqual("XXXIX", inRoman.Result);
		}


		[Test]
		public void CanConvertOneHundredSixty()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"160"});

			Assert.AreEqual("CLX", inRoman.Result);
		}


		[Test]
		public void CanConvertTwoHundredSeven()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"207"});

			Assert.AreEqual("CCVII", inRoman.Result);
		}


		[Test]
		public void CanConvertTwoHundredFortySix()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"246"});

			Assert.AreEqual("CCXLVI", inRoman.Result);
		}


		[Test]
		public void CanConvertFourHundredTwentyOne()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"421"});

			Assert.AreEqual("CDXXI", inRoman.Result);
		}


		[Test]
		public void CanConvertOneThousandSixtySix()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"1066"});

			Assert.AreEqual("MLXVI", inRoman.Result);
		}


		[Test]
		public void CanConvertOneThousandSevenHundredSeventySix()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"1776"});

			Assert.AreEqual("MDCCLXXVI", inRoman.Result);
		}


		[Test]
		public void CanConvertOneThousandNineHundredFiftyFour()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"1954"});

			Assert.AreEqual("MCMLIV", inRoman.Result);
		}


		[Test]
		public void CanConvertOneThousandNineHundredNinety()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"1990"});

			Assert.AreEqual("MCMXC", inRoman.Result);
		}


		[Test]
		public void CanConvertTwoThousandFourteen()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"2014"});

			Assert.AreEqual("MMXIV", inRoman.Result);
		}


		[Test]
		public void CanConvertTwoThousandNineteen()
		{
			Attempt<string> inRoman = _inputConverter.Convert(new[] {"2019"});

			Assert.AreEqual("MMXIX", inRoman.Result);
		}
	}
}