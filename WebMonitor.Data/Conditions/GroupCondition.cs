using System;
using System.Collections.Generic;
using System.Linq;

namespace WebMonitor.Data.Conditions
{
	public class NotCondition<T> : BaseCondition<T>
	{
		public ICondition<T> Condition { get; private set; }

		public NotCondition(ICondition<T> condition)
		{
			Condition = condition ?? throw new ArgumentException("Condition can't be null", nameof(condition));
		}
		
		public override bool IsMet(T input)
		{
			return !Condition.IsMet(input);
		}
	}
}
