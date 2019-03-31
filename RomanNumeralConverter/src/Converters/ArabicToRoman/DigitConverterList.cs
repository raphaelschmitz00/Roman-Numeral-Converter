using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RomanNumeralConverter.Converters.ArabicToRoman
{
	public class DigitConverterList : IDigitConverterList
	{
		private readonly List<IDigitConverter> _digitConverters;


		public DigitConverterList()
		{
			_digitConverters = new List<IDigitConverter>();
		}


		public void Add(IDigitConverter digitConverter)
		{
			_digitConverters.Add(digitConverter);
		}


		public string Convert(int arabic)
		{
			IOrderedEnumerable<IDigitConverter> digitConverters = _digitConverters.OrderByDescending(x => x.Position);

			StringBuilder stringBuilder = new StringBuilder();
			foreach (IDigitConverter digitConverter in digitConverters)
			{
				string digitInRoman = digitConverter.GetRomanNumeralForPosition(arabic);
				stringBuilder.Append(digitInRoman);
			}

			return stringBuilder.ToString();
		}
	}
}