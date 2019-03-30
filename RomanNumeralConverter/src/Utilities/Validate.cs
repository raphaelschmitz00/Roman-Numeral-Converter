using System;


namespace RomanNumeralConverter.Utilities
{
	public static class Validate
	{
		public static T NotNull<T>(T value) where T : class
		{
			if (ReferenceEquals(value, null)) throw new ArgumentNullException();
			return value;
		}
	}
}