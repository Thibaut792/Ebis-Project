using MySqlConnector;
using System.Diagnostics;

namespace Ebis;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
        connection.Open();

        var command = new MySqlCommand("SELECT Adresse_Ville from station;", connection);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            Debug.WriteLine(reader.GetString(0));
        }

    }
    private async void OnPage1ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalDesOperations());
    }

    private async void OnPage2ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalDesIncidents());
    }

    private async void OnPage3ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalEntretien());
    }

    private async void OnPage4ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AccueilPage());
    }

}



