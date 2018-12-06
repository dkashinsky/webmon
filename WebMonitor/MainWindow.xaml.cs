using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebMonitor.ViewModels;

namespace WebMonitor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		protected NotifyIcon TrayIcon { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainWindowViewModel();
			
			TrayIcon = new NotifyIcon
			{
				Icon = System.Drawing.Icon.FromHandle(Properties.Resources.Clover.GetHicon()),
				Visible = true
			};
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			if (TrayIcon != null)
			{
				TrayIcon.Dispose();
				TrayIcon = null;
			}
		}
	}
}
