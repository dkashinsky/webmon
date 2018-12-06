using System;
using System.Threading.Tasks;

namespace WebMonitor.Infrastructure
{
	public class AsyncCommand : AsyncCommandBase
	{
		private readonly Func<Task> _command;
		private readonly Predicate<object> _canExecute;

		public AsyncCommand(Func<Task> command)
		{
			_command = command ?? throw new ArgumentNullException(nameof(command));
		}

		public AsyncCommand(Func<Task> command, Predicate<object> canExecute)
			: this(command)
		{
			_canExecute = canExecute;
		}

		public override bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute(parameter);
		}

		public override Task ExecuteAsync(object parameter)
		{
			return _command();
		}
	}
}
