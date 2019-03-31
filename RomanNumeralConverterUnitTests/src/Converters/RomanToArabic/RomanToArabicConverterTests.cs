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
			_validatorMock.Setup(x => x.IsARomanNumber(It.IsAny<string>())).Returns(false);

			Attempt<int> attempt = _romanToArabicConverter.Convert("3");

			Assert.IsTrue(attempt.Failed);
		}


		[Test]
		public void PositiveValidationReturnsTheDigitConverterResult()
		{
			_validatorMock.Setup(x => x.IsARomanNumber(It.IsAny<string>())).Returns(true);
			int returnValue = 3;
			_valueGathererMock.Setup(x => x.GetValue()).Returns(returnValue);

			Attempt<int> attempt = _romanToArabicConverter.Convert("II");

			Assert.AreEqual(returnValue, attempt.Result);
		}
	}
}