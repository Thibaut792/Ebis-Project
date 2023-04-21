using Azure;
using Ebis.Model;
using MySqlConnector;
namespace Ebis.Services
{
    public class TechnicienService
    {
        public List<Technicien> GetTechnicien()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
            connection.Open();

            var Technicien = new MySqlCommand("SELECT nom, libelle FROM ebis_project.technicien join secteur_technicien on id_secteurtechnicien = fk_secteur_technicien", connection);
            var reader = Technicien.ExecuteReader();

            List<Technicien> Techniciens = new();
            while (reader.Read())
            {
                Technicien technicien = new();
                technicien.Nom = (string)reader["nom"];
                technicien.Libelle = (string)reader["libelle"];
                Techniciens.Add(technicien);
            }
            return Techniciens;
        }
    }
}