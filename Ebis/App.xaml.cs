using Microsoft.Maui.Handlers;
using Microsoft.Maui.LifecycleEvents;

namespace Ebis;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}


}


