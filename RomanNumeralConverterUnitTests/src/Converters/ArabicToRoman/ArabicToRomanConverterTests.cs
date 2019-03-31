using Moq;
using NUnit.Framework;
using RomanNumeralConverter.Converters.ArabicToRoman;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.Converters.ArabicToRoman
{
	public class ArabicToRomanConverterTests
	{
		private Mock<IArabicNumeralValidator> _validatorMock;
		private Mock<IDigitConverterList> _converterListMock;
		private ArabicToRomanConverter _arabicToRomanConverter;


		[SetUp]
		public void SetUp()
		{
			_validatorMock = new Mock<IArabicNumeralValidator>();
			_converterListMock = new Mock<IDigitConverterList>();
			_arabicToRomanConverter = new ArabicToRomanConverter(_validatorMock.Object, _converterListMock.Object);
		}


		[Test]
		public void FailedValidationLeadsToFailedResult()
		{
			Error error = new Error("FAIL");
			Attempt<int> fail = new Attempt<int>(error);
			_validatorMock.Setup(x => x.ConvertToArabicNumber(It.IsAny<string>())).Returns(fail);

			Attempt<string> attempt = _arabicToRomanConverter.Convert("3");

			Assert.IsFalse(attempt.Failed);
		}


		[Test]
		public void PositiveValidationReturnsTheDigitConverterResult()
		{
			Attempt<int> success = new Attempt<int>(3);
			_validatorMock.Setup(x => x.ConvertToArabicNumber(It.IsAny<string>())).Returns(success);
			string returnValue = "warblgarbl";
			_converterListMock.Setup(x => x.Convert(It.IsAny<int>())).Returns(returnValue);

			Attempt<string> attempt = _arabicToRomanConverter.Convert("3");

			Assert.AreEqual(returnValue, attempt.Result);
		}
	}
}