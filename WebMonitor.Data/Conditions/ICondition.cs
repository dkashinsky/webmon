namespace WebMonitor.Data.Conditions
{
	public interface ICondition<in T>
	{
		bool IsMet(T input);
	}
}
