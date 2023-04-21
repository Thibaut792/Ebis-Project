using Ebis.ViewModel;

namespace Ebis.View;

public partial class EntretienPage : ContentPage
{
	public EntretienPage(EntretienViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}