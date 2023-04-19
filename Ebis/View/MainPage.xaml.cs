using Ebis.ViewModel;

namespace Ebis;


public partial class MainPage : ContentPage
{
    public MainPage(BorneViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}




