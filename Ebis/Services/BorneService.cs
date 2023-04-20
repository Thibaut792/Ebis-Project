using Azure;
using Ebis.Model;
using MySqlConnector;
namespace Ebis.Services
{
    public class BorneService
    {  
        public List<Borne> GetBorne()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=2010Thibaut;Database=ebis_project");
            connection.Open();

            var Borne = new MySqlCommand("SELECT idBorne, Adresse_Ville, Adresse_Rue, Code_Postal, libelle_type_charge FROM ebis_project.borne\r\njoin station on fk_station = idStation\r\njoin type_charge on code_type_charge = fk_type_charge ", connection);
            var reader = Borne.ExecuteReader();

            List<Borne> Bornes = new();
            while (reader.Read())
            {
                Borne borne = new();
                borne.idBorne = (Int32)reader["idBorne"];
                borne.Adresse_Ville = (string)reader["Adresse_Ville"];
                borne.Adresse_Rue = (string)reader["Adresse_Rue"];
                borne.Code_Postal = (Int32)reader["Code_Postal"];
                borne.libelle_type_charge = (String)reader["libelle_type_charge"];
                Bornes.Add(borne);
            }
            return Bornes;
        }
    }
}
