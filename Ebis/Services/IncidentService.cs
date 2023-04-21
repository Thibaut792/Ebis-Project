using Ebis.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Services
{
    public class IncidentService
    {

        public List<Incident> GetIncident()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
            connection.Open();

            var Incident = new MySqlCommand("SELECT details_incident, libelle, idBorne FROM ebis_project.journal_incident join type_incident on fk_type_incident = id_type_incident join borne on fk_incident_borne = idBorne limit 10;", connection);
            var reader = Incident.ExecuteReader();

            List<Incident> Incidents = new();

            while (reader.Read())
            {
                Incident incident = new();
                incident.idBorne = (Int32)reader["idBorne"];
                incident.details_incident = (string)reader["details_incident"];
                incident.libelle = (string)reader["libelle"];
                Incidents.Add(incident);
            }
            return Incidents;
        }
    }
}
