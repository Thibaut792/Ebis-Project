using Azure;
using Ebis.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ebis.Services
{
    public class BorneService
    {
        List<Borne> bornesList = new();
        public List<Borne> GetBorne(int limite)
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=2010Thibaut;Database=ebis_project");
            connection.Open();

            var command = new MySqlCommand("SELECT Adresse_Ville from station;", connection);
            var reader = command.ExecuteReader();


            List<Borne> centresLimite = new();
            for (int i = 0; i < limite; i++)
            {
                centresLimite.Add(bornesList[i]);
            }
            return bornesList;
        }
    }
}
