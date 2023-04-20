using Ebis.ViewModel;

namespace Ebis.View;


public partial class MainPage : ContentPage
{
    public MainPage(BorneViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}




