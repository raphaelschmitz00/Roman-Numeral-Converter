namespace RomanNumeralConverter.Errors
{
	public class Attempt<T>
	{
		public Attempt(Error error)
		{
			Error = error;
			Failed = true;
		}


		public Attempt(T result)
		{
			Result = result;
			Failed = false;
		}


		public bool Failed { get; }
		public Error Error { get; }
		public T Result { get; }
	}
}