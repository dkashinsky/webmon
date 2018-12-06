﻿using System.Threading.Tasks;
using System.Windows.Input;

namespace WebMonitor.Infrastructure
{
	public interface IAsyncCommand: ICommand
	{
		Task ExecuteAsync(object parameter);
	}
}
