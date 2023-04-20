namespace Ebis;

public partial class AccueilPage : ContentPage
{
	public AccueilPage()
	{
		InitializeComponent();
	}
    private async void OnButton1Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ListBorne());
    }
    private async void OnButton2Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Technicien());
    }
    private async void OnButton3Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AccueilPage());
    }
    private async void OnButton4Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Geolocalisation());
    }

}