using System;
using System.Collections.Generic;
using System.Linq;

namespace WebMonitor.Data.Conditions
{
	public class GroupCondition<T> : BaseCondition<T>
	{
		public Combinator Combinator { get; private set; }
		public readonly List<ICondition> Conditions = new List<ICondition>();

		public GroupCondition(params ICondition<T>[] conditions)
			: this(Combinator.And, conditions) { }

		public GroupCondition(Combinator combinator, params ICondition<T>[] conditions)
		{
			if (conditions == null || conditions.Length < 2)
				throw new ArgumentException("At least 2 conditions are expected", nameof(conditions));

			Combinator = combinator;
			Conditions.AddRange(conditions);
		}
		
		public override bool IsMet(T input)
		{
			if (Combinator == Combinator.And)
				return Conditions.All(condition => condition.IsMet(input));
			else
				return Conditions.Any(condition => condition.IsMet(input));
		}
	}
}
