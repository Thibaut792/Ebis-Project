using Ebis.ViewModel;

namespace Ebis.View;

public partial class BornePage : ContentPage
{
	public BornePage(infoBorneViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}