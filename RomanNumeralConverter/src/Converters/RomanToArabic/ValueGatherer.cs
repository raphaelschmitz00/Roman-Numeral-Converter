using RomanNumeralConverter.Units;


namespace RomanNumeralConverter.Converters.RomanToArabic
{
	public class ValueGatherer : IValueGatherer
	{
		private int _currentValue;
		private RomanDigit _lastDigit;


		public ValueGatherer()
		{
			_currentValue = 0;
		}


		public void Reset()
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


		public int GetValue()
		{
			return _currentValue;
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
	}
}