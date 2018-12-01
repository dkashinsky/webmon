using System.Text.RegularExpressions;

namespace WebMonitor.Data.Conditions
{
	public class RegexCondition: BaseCondition<string>
	{
		public Regex Regex { get; private set; }

		public RegexCondition(Regex regex)
		{
			Regex = regex;
		}

		public override bool IsMet(string input)
		{
			return Regex.IsMatch(input);
		}
	}
}
