using MySqlConnector;
using System.Diagnostics;

namespace Ebis;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=2010Thibaut;Database=ebis_project");
        connection.Open();

        var command = new MySqlCommand("SELECT Adresse_Ville from station;", connection);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            Debug.WriteLine(reader.GetString(0));
        }
    }
}



