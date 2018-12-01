using System.Text.RegularExpressions;

namespace WebMonitor.Data.Conditions
{
	public class RegexCondition: ICondition<string>
	{
		public Regex Regex { get; private set; }

		public RegexCondition(Regex regex)
		{
			Regex = regex;
		}

		public bool IsMet(string input)
		{
			return Regex.IsMatch(input);
		}
	}
}
