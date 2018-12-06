using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMonitor.Data.Conditions;

namespace WebMonitor.ViewModels
{
	public class ResourceViewModel: ViewModelBase
	{
		public string ResourceUrl
		{
			get => GetValue<string>(nameof(ResourceUrl));
			set => SetValue(nameof(ResourceUrl), value);
		}
	}
}
