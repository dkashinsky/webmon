using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WebMonitor.Infrastructure;

namespace WebMonitor.ViewModels
{
	public class MainWindowViewModel: ViewModelBase
	{
		public ICommand AddNew { get; private set; }
		public ObservableCollection<ResourceViewModel> Resources { get; set; }

		public MainWindowViewModel()
		{
			AddNew = new ActionCommand(o => AddNewResource());
			Resources = new ObservableCollection<ResourceViewModel>();
		}

		public void AddNewResource()
		{
			var vm = new ResourceViewModel();
			vm.ResourceUrl = "resource url goes here...";
			Resources.Add(vm);
		}
	}
}
