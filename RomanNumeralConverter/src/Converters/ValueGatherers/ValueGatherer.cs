using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters.ValueGatherers
{
	public class ValueGatherer
	{
		private int _currentValue;


		public ValueGatherer()
		{
			_currentValue = 0;
		}


		public void Add(RomanDigit romanDigit)
		{
			if (romanDigit.Value > _currentValue) _currentValue = romanDigit.Value - _currentValue;
			else _currentValue += romanDigit.Value;
		}


		public int GetValue()
		{
			return _currentValue;
		}
	}
}