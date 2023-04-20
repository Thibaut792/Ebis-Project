using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Model
{
    public class Operation
    {
        public Int32 numOperation { get; set; }
        public DateTime dateheureDebut { get; set; }
        public DateTime dateheurefin { get; set; }
        public Int32 nbKwHeure { get; set; }
        public string fk_rechargement_borne { get; set; }
        public Int32 idBorne { get; set; }
        public string libelle_type_charge { get; set; }
    }
}
