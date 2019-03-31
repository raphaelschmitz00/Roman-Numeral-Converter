using NUnit.Framework;
using RomanNumeralConverter.Converters.ValueGatherers;
using RomanNumeralConverter.Units;


namespace RomanNumeralConverterUnitTests.Converters.ValueGatherers
{
	public class ValueGathererTests
	{
		[Test]
		public void CorrectlyGathersOne()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1, result);
		}


		[Test]
		public void CorrectlyGathersTwo()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(2, result);
		}


		[Test]
		public void CorrectlyGathersFour()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.V);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(4, result);
		}


		[Test]
		public void CorrectlyGathersSix()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(6, result);
		}


		[Test]
		public void CorrectlyGathersNine()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.X);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(9, result);
		}


		[Test]
		public void CorrectlyGathersEleven()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(11, result);
		}


		[Test]
		public void CorrectlyGathersThirtyNine()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.X);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(39, result);
		}


		[Test]
		public void CorrectlyGathersOneHundredSixty()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.L);
			valueGatherer.Add(RomanDigit.X);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(160, result);
		}


		[Test]
		public void CorrectlyGathersTwoHundredSeven()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(207, result);
		}


		[Test]
		public void CorrectlyGathersTwoHundredFortySix()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.L);
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(246, result);
		}


		[Test]
		public void CorrectlyGathersFourHundredTwentyOne()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.D);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(421, result);
		}


		[Test]
		public void CorrectlyGathersOneThousandSixtySix()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.L);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1066, result);
		}


		[Test]
		public void CorrectlyGathersOneThousandSevenHundredSeventySix()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.D);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.L);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.V);
			valueGatherer.Add(RomanDigit.I);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1776, result);
		}


		[Test]
		public void CorrectlyGathersOneThousandNineHundredFiftyFour()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.L);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.V);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1954, result);
		}


		[Test]
		public void CorrectlyGathersOneThousandNineHundredNinety()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.C);
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.C);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(1990, result);
		}


		[Test]
		public void CorrectlyGathersTwoThousandFourteen()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.V);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(2014, result);
		}


		[Test]
		public void CorrectlyGathersTwoThousandNineteen()
		{
			ValueGatherer valueGatherer = new ValueGatherer();
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.M);
			valueGatherer.Add(RomanDigit.X);
			valueGatherer.Add(RomanDigit.I);
			valueGatherer.Add(RomanDigit.X);

			int result = valueGatherer.GetValue();

			Assert.AreEqual(2019, result);
		}
	}
}