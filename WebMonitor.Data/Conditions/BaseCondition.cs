namespace WebMonitor.Data.Conditions
{
	public abstract class BaseCondition<T> : ICondition<T>
	{
		public abstract bool IsMet(T input);

		public bool IsMet(object input)
		{
			return IsMet((T)input);
		}
	}
}
