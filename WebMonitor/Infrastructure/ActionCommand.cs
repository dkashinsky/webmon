using System;
using System.Windows.Input;

namespace WebMonitor.Infrastructure
{
	public class ActionCommand : ICommand
	{
		private readonly Predicate<object> _canExecute;
		private readonly Action<object> _action;

		public ActionCommand(Action<object> action)
		{
			_action = action ?? throw new ArgumentNullException(nameof(action));
		}

		public ActionCommand(Action<object> action, Predicate<object> canExecute)
			:this(action)
		{
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			_action(parameter);
		}
		
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void RaiseCanExecuteChanged()
		{
			CommandManager.InvalidateRequerySuggested();
		}
	}
}
