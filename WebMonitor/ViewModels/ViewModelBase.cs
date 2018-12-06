using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMonitor.ViewModels
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		private readonly Dictionary<string, object> Properties = new Dictionary<string, object>();

		public T GetValue<T>(string property)
		{
			if (Properties.ContainsKey(property))
				return (T)Properties[property];

			return default(T);
		}

		public bool SetValue<T>(string property, T value)
		{
			var current = GetValue<T>(property);
			var isUpdated = !EqualityComparer<T>.Default.Equals(current, value);

			if (isUpdated)
			{
				if (Properties.ContainsKey(property))
					Properties[property] = value;
				else
					Properties.Add(property, value);

				NotifyPropertyChanged(property);
			}

			return isUpdated;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
