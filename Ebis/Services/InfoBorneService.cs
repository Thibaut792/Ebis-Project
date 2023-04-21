using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebis.Model;

namespace Ebis.Services
{
    public class InfoBorneService
    {
       public List<Borne> GetBorne()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
            connection.Open();

            var Borne = new MySqlCommand("SELECT idBorne, date_mise_en_service, date_derniere_revision, libelle_type_charge  FROM ebis_project.borne join type_charge on borne.fk_type_charge = code_type_charge; ", connection);
            var reader = Borne.ExecuteReader();

            List<Borne> Bornes = new();
            while (reader.Read())
            {
                Borne borne = new();
                borne.idBorne = (Int32)reader["idBorne"];
                borne.date_mise_en_service = (DateTime)reader["date_mise_en_service"];
                borne.date_derniere_revision = (DateTime)reader["date_derniere_revision"];
                borne.libelle_type_charge = (String)reader["libelle_type_charge"];
                Bornes.Add(borne);
            }
            return Bornes;
        }

    }
}
