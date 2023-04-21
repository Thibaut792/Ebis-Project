using Ebis.View;

namespace Ebis;

public partial class AppShell : Shell 
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("BornePage", typeof(BornePage));
        Routing.RegisterRoute(nameof(EntretienPage), typeof(EntretienPage));
        Routing.RegisterRoute(nameof(Incident), typeof(Incident));
        Routing.RegisterRoute(nameof(OperationPage), typeof(OperationPage));
        Routing.RegisterRoute(nameof(BornePage), typeof(BornePage));
        Routing.RegisterRoute(nameof(Geocalisation), typeof(Geocalisation));
        Routing.RegisterRoute(nameof(Technicien), typeof(Technicien));

    }
}
