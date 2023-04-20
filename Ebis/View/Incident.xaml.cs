using Ebis.ViewModel;

namespace Ebis.View;

public partial class Incident : ContentPage
{
	public Incident(BorneViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}