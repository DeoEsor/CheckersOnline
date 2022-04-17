using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace CheckersDesktop
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			IUnityContainer container = new UnityContainer();
			//container.RegisterType<IDataServices, TextDataServices>();
			//container.RegisterType<ITextViewModel, TextViewModel>();

			var window = container.Resolve<MainWindow>();
			window.Show();
		}
	}
}
