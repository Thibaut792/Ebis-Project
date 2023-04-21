using Ebis.ViewModel;

namespace Ebis.View;

public partial class Incident : ContentPage
{
	public Incident(IncidentViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}