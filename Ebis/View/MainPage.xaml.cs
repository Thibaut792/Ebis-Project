
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

        //await Navigation.PushAsync(new OperationPage(new OperationViewModel(new)));
    }
    private async void OnButton2Clicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new Technicien());
    }
    private async void OnButton3Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new AccueilPage());
    }
    private async void OnButton4Clicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new Geolocalisation());
    }

}




