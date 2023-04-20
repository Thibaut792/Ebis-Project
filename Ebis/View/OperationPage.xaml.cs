using Ebis.ViewModel;

namespace Ebis.View;

public partial class OperationPage : ContentPage
{
	public OperationPage(OperationViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}