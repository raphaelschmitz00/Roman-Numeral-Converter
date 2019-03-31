using Moq;
using NUnit.Framework;
using RomanNumeralConverter.Converters.RomanToArabic;
using RomanNumeralConverter.Errors;


namespace RomanNumeralConverterUnitTests.Converters.RomanToArabic
{
	public class RomanToArabicConverterTests
	{
		private Mock<IRomanNumeralValidator> _validatorMock;
		private Mock<IValueGatherer> _valueGathererMock;
		private RomanToArabicConverter _romanToArabicConverter;


		[SetUp]
		public void SetUp()
		{
			_validatorMock = new Mock<IRomanNumeralValidator>();
			_valueGathererMock = new Mock<IValueGatherer>();
			_romanToArabicConverter = new RomanToArabicConverter(_validatorMock.Object, _valueGathererMock.Object);
		}


		[Test]
		public void FailedValidationLeadsToFailedResult()
		{
			Error error = new Error("FAIL");
			Attempt<string> fail = new Attempt<string>(error);
			_validatorMock.Setup(x => x.ConvertToRomanNumber(It.IsAny<string>())).Returns(fail);

			Attempt<int> attempt = _romanToArabicConverter.Convert("3");

			Assert.IsFalse(attempt.Failed);
		}


		[Test]
		public void PositiveValidationReturnsTheDigitConverterResult()
		{
			Attempt<string> success = new Attempt<string>("");
			_validatorMock.Setup(x => x.ConvertToRomanNumber(It.IsAny<string>())).Returns(success);
			int returnValue = 3;
			_valueGathererMock.Setup(x => x.GetValue()).Returns(returnValue);

			Attempt<int> attempt = _romanToArabicConverter.Convert("3");

			Assert.AreEqual(returnValue, attempt.Result);
		}
	}
}