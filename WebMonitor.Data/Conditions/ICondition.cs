namespace WebMonitor.Data.Conditions
{
	public interface ICondition
	{
		bool IsMet(object input);
	}

	public interface ICondition<in T>: ICondition
	{
		bool IsMet(T input);
	}
}
