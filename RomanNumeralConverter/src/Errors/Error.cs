namespace RomanNumeralConverter.Errors
{
	public class Error
	{
		public static readonly Error None = new Error();


		public Error(string message)
		{
			IsNone = false;
			Message = message;
		}


		private Error()
		{
			IsNone = true;
			Message = "";
		}


		public bool IsNone { get; }
		public string Message { get; }
	}
}