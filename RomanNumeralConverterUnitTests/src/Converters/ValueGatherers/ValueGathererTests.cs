using NUnit.Framework;
using RomanNumeralConverter.Converters.ValueGatherers;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Converters.ValueGatherers
{
	public class ValueGathererTests
	{
		[Test]
		public void CorrectlyAddsOne()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1, result);
		}


		[Test]
		public void CorrectlyAddsTwo()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(2, result);
		}


		[Test]
		public void CorrectlyAddsFour()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.V);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(4, result);
		}


		[Test]
		public void CorrectlyAddsSix()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(6, result);
		}


		[Test]
		public void CorrectlyAddsNine()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.X);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(9, result);
		}


		[Test]
		public void CorrectlyAddsEleven()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(11, result);
		}


		[Test]
		public void DoesNotStopIfASmallerLetterIsGiven()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);


			bool result = valueGatherer.CanAddLetters;

			Assert.IsFalse(result);
		}


		[Test]
		public void StopsIfABiggerLetterIsGiven()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.I);


			bool result = valueGatherer.CanAddLetters;

			Assert.IsFalse(result);
		}
	}
}