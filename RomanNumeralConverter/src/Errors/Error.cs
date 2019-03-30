namespace RomanNumeralConverter.Errors
{
	public class Error
	{
		public static readonly Error None = new Error();


		public Error(string message)
		{
			throw new System.NotImplementedException();
		}


		private Error()
		{
			throw new System.NotImplementedException();
		}


		public bool IsNone { get; }
		public string Message { get; }
	}
}