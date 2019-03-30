using System;
using NUnit.Framework;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Units
{
	[TestFixture]
	public class RomanNumeralTests
	{
		[Test]
		public void CantBeConstructedWithNullString()
		{
			Assert.Throws<ArgumentNullException>(() => new RomanNumeral(null));
		}
		
		
	}
}