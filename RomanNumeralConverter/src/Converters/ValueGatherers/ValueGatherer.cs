using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters.ValueGatherers
{
	public class ValueGatherer
	{
		private int _currentValue;
		private RomanDigit _lastDigit;


		public ValueGatherer()
		{
			_currentValue = 0;
		}


		public void Add(RomanDigit romanDigit)
		{
			bool previousValueWasSmaller = _lastDigit != null && romanDigit.Value > _lastDigit.Value;
			if (previousValueWasSmaller) CalculateSubtractiveNotation(romanDigit);
			else AddValue(romanDigit.Value);
			_lastDigit = romanDigit;
		}


		/// <summary>
		/// With subtractive notation, XIV does not represent the same number as XVI (16) but rather is an alternative
		/// way of writing XIIII (14).
		/// </summary>
		private void CalculateSubtractiveNotation(RomanDigit romanDigit)
		{
			UndoLastAddition();
			int combinedValue = CombineWithPreviousValue(romanDigit);
			AddValue(combinedValue);
		}


		private void UndoLastAddition()
		{
			_currentValue -= _lastDigit.Value;
		}


		private int CombineWithPreviousValue(RomanDigit romanDigit)
		{
			return romanDigit.Value - _lastDigit.Value;
		}


		private void AddValue(int value)
		{
			_currentValue += value;
		}


		public int GetValue()
		{
			return _currentValue;
		}
	}
}