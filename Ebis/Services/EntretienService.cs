using Ebis.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Services
{
    public class EntretienService
    {
        public List<Entretien> GetEntretien()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
            connection.Open();

            var OperationsChargement = new MySqlCommand("SELECT idBorne, Adresse_Ville, Adresse_Rue, element_modifie, element_verifie, nom FROM ebis_project.borne\r\njoin station on fk_station = idStation\r\njoin journal_entretien on fk_entretien_borne = idBorne\r\njoin technicien on fk_entretien_borne = idtechnicien;", connection);
            var reader = OperationsChargement.ExecuteReader();

            List<Entretien> Entretiens = new();

            while (reader.Read())
            {
                Entretien entretien = new();
                entretien.idBorne = (Int32)reader["idBorne"];
                entretien.Adresse_Ville = (string)reader["Adresse_Ville"];
                entretien.Adresse_Rue = (string)reader["Adresse_Rue"];
                entretien.element_modifie = (string)reader["element_modifie"];
                entretien.nom = (string)reader["nom"];
                Entretiens.Add(entretien);
            }
            return Entretiens;
        }
    }
}
