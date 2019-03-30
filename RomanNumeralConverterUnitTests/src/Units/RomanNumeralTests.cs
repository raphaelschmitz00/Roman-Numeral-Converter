using System;
using NUnit.Framework;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Units
{
	[TestFixture]
	public class RomanNumeralTests
	{
		[Test]
		public void CantBeConstructedWithNullArgument()
		{
			Assert.Throws<ArgumentNullException>(() => new RomanNumeral(null));
		}
		
		
	}
}