
using Ebis.ViewModel;

namespace Ebis.View;

public partial class MainPage : ContentPage
{
    public MainPage(BorneViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    private async void OnButton1Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Accueil());
    }

}




