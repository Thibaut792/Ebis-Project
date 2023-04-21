using MySqlConnector;
using Ebis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Services
{
    public class OperationService
    {
        public List<Operation> GetOperation()
        {
            var connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=POKEMON17;Database=ebis_project");
            connection.Open();

            var OperationsChargement = new MySqlCommand("SELECT idBorne, dateheureDebut ,dateheurefin, nbKwHeure, libelle_type_charge FROM ebis_project.operation_rechargement join borne on fk_rechargement_borne = idBorne join type_charge on borne.fk_type_charge = code_type_charge;", connection);
            var reader = OperationsChargement.ExecuteReader();

            List<Operation> Operations = new();

            while (reader.Read())
            {
                Operation operation = new();
                operation.idBorne = (Int32)reader["idBorne"];
                operation.dateheureDebut = (DateTime)reader["dateheureDebut"];
                operation.dateheurefin = (DateTime)reader["dateheurefin"];
                operation.nbKwHeure = (Int32)reader["nbKwHeure"];
                operation.libelle_type_charge = (string)reader["libelle_type_charge"];
                Operations.Add(operation);
            }
            return Operations;
        }
    }
 }

