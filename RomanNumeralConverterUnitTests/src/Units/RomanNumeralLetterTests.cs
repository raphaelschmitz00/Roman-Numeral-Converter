using NUnit.Framework;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Units
{
	public class RomanNumeralLetterTests
	{
		[Test]
		public void ComparisonWorksTheRightWayAround()
		{
			bool oneIsSmallerThanTen = RomanNumeralLetter.I < RomanNumeralLetter.X;

			Assert.IsTrue(oneIsSmallerThanTen);
		}
	}
}