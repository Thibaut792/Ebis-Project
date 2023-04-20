using Ebis.View;

namespace Ebis;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("BornePage", typeof(BornePage));
    }
}
