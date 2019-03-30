namespace RomanNumeralConverter.Errors
{
	public class Attempt<T>
	{
		public Attempt(Error error)
		{
			throw new System.NotImplementedException();
		}


		public Attempt(T value)
		{
			Value = value;
		}


		public bool Failed { get; set; }
		public T Value { get; set; }
	}
}